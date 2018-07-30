using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;

namespace OYASAR.Penguin.Admin.Controllers
{
    [Route("api/[controller]")]
    [Authorize()]
    public class NurseController : AbstractController<INurseService>
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetNurse();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{nurseId}")]
        public IActionResult Get(int id)
        {
            var result = service.GetNurse(id);
            return Ok(result);
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            var result = service.GetNurses(name);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Nurse value)
        {
            service.AddNewNurse(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Nurse value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.DeleteNurse(id);
        }
    }
}