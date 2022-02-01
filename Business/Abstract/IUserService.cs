using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int userId);
        IDataResult<List<User>> GetAll();
        IResult Login(string mail, string password);
        IResult GetUserByEmail(string email);
        IResult SendMail(string email);
        IResult GetUserById(int id);
    }
}