using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("/postUser")]
        public IResult Post(User user)
        {
            return _userService.Add(user);
        }

        [HttpPut("/updateUser")]
        public IResult Update(User user)
        {
            return _userService.Update(user);
        }

        [HttpDelete("/deleteUser")]
        public IResult Delete(User user)
        {
            return _userService.Delete(user);
        }

        [HttpGet("/getAllUser")]
        public IDataResult<List<User>> GetAll()
        {
            return _userService.GetAll();
        }
    }
}