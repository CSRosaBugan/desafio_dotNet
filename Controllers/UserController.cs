using System.Collections.Generic;
using desafio.Models;
using Microsoft.AspNetCore.Mvc;
using desafio.Services;
using System;

namespace desafio.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("list")]
        public ActionResult<List<User>> Get() => _userService.Get();
        [HttpGet("{id:length(24)}", Name = "GetUser")]

        public ActionResult<User> Get(string id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
         
            return user;
        }
        [HttpPost]
        [Route("create")]
        public ActionResult<User> Create(User user)
            {
                if(ModelState.IsValid)
                {
                    user.data_criacao= DateTime.Now;
                    user.data_atualizacao= DateTime.Now;
                    _userService.Create(user);
                   
                    return CreatedAtRoute("GetUser", new {Id = user.Id.ToString() }, user);
                }
                else{
                    return BadRequest(ModelState);
                }
            }
    }
}
