using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Conctrete;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class UserMan : IUserService
    {
        public IUserDal _userDal;

        public UserMan(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Eklendi");
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
    }
}