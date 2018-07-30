using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OYASAR.Penguin.Core.Dto.User;
using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;

namespace OYASAR.Penguin.Admin.Controllers
{
    [Route("api/[controller]")]
    [Authorize()]
    public class UserController : AbstractController<IUserService>
    {
        [HttpGet]  // For Test
        public IActionResult Get()
        {
            var data = new User { Username = "oyasar" };

            var result = service.CreateOrLogin(data);

            if (result)
                return Ok();
            else
                return BadRequest();
        }
        
        // POST api/values
        [HttpPost()]
        public IActionResult Post([FromBody]User value)
        {
            var result = service.CreateOrLogin(value);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut()]
        public IActionResult Put([FromBody]User value)
        {
            var result = service.Modify(value);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete()]
        public void Delete([FromBody]User value)
        {
            var result = service.Delete();
        }
    }

    public class Result 
    {
        public string Name { get; set; }
        public string UserName { get;set; }
        public bool Error { get; set;}

        public LoginRes User {get;set;}
    }
}