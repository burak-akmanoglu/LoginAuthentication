using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace LoginAuthenticationApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult UserList()
        {
            using var c = new Context();
            return Ok(c.Users.ToList());
        }
        
        [HttpPost]
        public IActionResult UserAdd(User p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public IActionResult UserGet(int id)
        {
            using var c = new Context();
            var value = c.Users.Find(id);

            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }

        }

        [HttpDelete]
        public IActionResult UserDelete(int id)
        {
            using var c = new Context();
            var value = c.Users.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        
        [HttpPut]
        public IActionResult UserUpdate(User p)
        {
            using var c = new Context();
            var value = c.Find<User>(p.Id);

            if (value == null)
            {
                return NotFound();

            }
            else
            {
                value.Name = p.Name;
                value.SurName = p.SurName;
                value.Email = p.Email;
                value.Password = p.Password;
                value.Role = p.Role;
        

                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
   
    }
}
