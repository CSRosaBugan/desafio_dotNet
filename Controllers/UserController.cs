using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using desafio.data;
using desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<List<User>>> Get([FromServices] DataContext context)
        {
            var users = await context.Users.ToListAsync();
            return users;
        }
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<User>> Post(
            [FromServices] DataContext context,
            [FromBody]User model)
            {
                if(ModelState.IsValid)
                {
                    model.data_criacao= DateTime.Now;
                    model.data_atualizacao= DateTime.Now;
                    context.Users.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }
                else{
                    return BadRequest(ModelState);
                }
            }
    }
}
