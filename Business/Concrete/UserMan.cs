using System.Collections.Generic;
using Business.Abstract;
using Business.Adapters.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserMan : IUserService
    {
        private readonly IMailService _mailService;
        private readonly IMernisServiceAdapter _mernisServiceAdapter;
        private readonly IUserDal _userDal;

        public UserMan(IUserDal userDal, IMernisServiceAdapter mernisServiceAdapter, IMailService mailService)
        {
            _userDal = userDal;
            _mernisServiceAdapter = mernisServiceAdapter;
            _mailService = mailService;
        }


        public IResult Add(User user)
        {
            //Mernis kontrolu sağlanır   
            //_mernisServiceAdapter.VerifyCid(user).Result &&
            if (_mernisServiceAdapter.VerifyCid(user).Result && isMailExist(user.Email) &&
                isIdentityExist(user.IdentityNumber))

            {
                user.IsMernisOk = true;
                _userDal.Add(user);

                return new Result(true, "Eklendi");
            }

            if (isIdentityExist(user.IdentityNumber) == false) return new ErrorResult("Bu Kimlik Numarası Kullanılmış");

            if (isMailExist(user.Email) == false) return new ErrorResult("Mail adresi kullanılmış");
            return new ErrorResult("Kullanıcı Eklenemedi Lütfen Değerleri kontrol Ediniz");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Güncellendi");
        }

        public IResult Delete(int userId)
        {
            var result = _userDal.Get(user => user.UserId == userId);
            _userDal.Delete(result);

            return new SuccessResult("Silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), "Getirildi");
        }

        public IResult Login(string mail, string password)
        {
            var result = _userDal.Get(user => user.Email == mail);

            if (result == null)
                return new Result(false, "giriş başarısız");
            if (result.Password.Equals(password)) return new Result(true, "giriş başarılı");
            {
                return new Result(false, "giriş başarısız");
            }
        }

        public IResult GetUserByEmail(string email)

        {
            var result = _userDal.Get(user => email == user.Email);
            if (result == null) return new ErrorResult("data yok");

            return new SuccessDataResult<string>(result.UserId.ToString(), "data getirildi");
        }

        public IResult SendMail(string email)
        {
            var result = _userDal.Get(user => email == user.Email);


            if (!isMailExist(result.Email))
            {
                _mailService.SendMailForPassword(result);
                return new SuccessResult("Mail Gönderildi");
            }

            return new ErrorResult("Mail Gönderilemedi");
        }


        public IResult GetUserById(int id)
        {
            var result = _userDal.Get(user => id == user.UserId);
            return new DataResult<User>(result, true, "data geldi");
        }

        private bool isMailExist(string mail)
        {
            var result = _userDal.Get(user => mail == user.Email);
            if (result == null)
                return true;
            return false;
        }

        private bool isIdentityExist(string identitynumber)
        {
            var result = _userDal.Get(user => identitynumber == user.IdentityNumber);
            if (result == null)
                return true;
            return false;
        }
    }
}