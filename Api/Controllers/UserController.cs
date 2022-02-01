using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

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
        public IResult Post([FromBody]User user)
        {
            return _userService.Add(user);
        }

        [HttpPut("/updateUser")]
        public IResult Update([FromBody] User user)
        {
            return _userService.Update(user);
        }

        [HttpDelete("/deleteUser")]
        public IResult Delete(int userId)
        {
            return _userService.Delete(userId);
        }

        [HttpGet("/getAllUser")]
        public IDataResult<List<User>> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet("/Login")]
        public IResult Login(string mail, string password)
        {
            return _userService.Login(mail, password);
        }
        
        
        [HttpGet("/getUserByEmail")]
        public IResult GetUserByEmail(string mail)
        {
            return _userService.GetUserByEmail(mail);
        }

        [HttpGet("/getUserById")]
        public IResult GetUserId(int id)
        {
            return _userService.GetUserById(id);
        }
    }
}