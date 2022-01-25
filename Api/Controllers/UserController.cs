using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("/PostUser")] 
        public IResult Post(User user)
        {
            //_userService.Add(user);
            return _userService.Add(user);
           
        }
        //  [HttpPost("/PostUser")]
        //public ActionResult Post(User user)
        //{
        //    _userService.Add(user);
        //     var result = _userService.Add(user);
        //    return !result.Success ? BadRequest(result) : Ok(result);
        //}

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

        [HttpGet("/getAll")]
        public IDataResult<List<User>> GetAll()
        {
            
            return _userService.GetList();
        }



    }
}
