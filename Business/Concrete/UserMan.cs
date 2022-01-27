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
        private IMernisServiceAdapter _mernisServiceAdapter;
        private IUserDal _userDal;

        public UserMan(IUserDal userDal, IMernisServiceAdapter mernisServiceAdapter)
        {
            _userDal = userDal;
            _mernisServiceAdapter = mernisServiceAdapter;
        }


        public IResult Add(User user)
        {
            if (_mernisServiceAdapter.VerifyCid(user).Result)
            {
                _userDal.Add(user);
                return new SuccessResult("Eklendi");
            }
           
            return new ErrorResult("Kullanıcı Eklenemedi Lütfen Değerleri kontrol Ediniz");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Güncellendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), "Getirildi");
        }
    }
}