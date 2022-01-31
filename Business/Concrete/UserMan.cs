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
        private readonly IMernisServiceAdapter _mernisServiceAdapter;
        private readonly IUserDal _userDal;

        public UserMan(IUserDal userDal, IMernisServiceAdapter mernisServiceAdapter)
        {
            _userDal = userDal;
            _mernisServiceAdapter = mernisServiceAdapter;
        }


        public IResult Add(User user)
        {
            //Mernis kontrolu sağlanır
            if (_mernisServiceAdapter.VerifyCid(user).Result && isMailExist(user.Email)) //
            {
                user.IsMernisOk = true;
                _userDal.Add(user);

                return new Result(true, "Eklendi");
            }

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

        public bool isMailExist(string mail)
        {
            var result = _userDal.Get(user => mail == user.Email);
            if (result == null)
                return true;
            return false;
        }
    }
}