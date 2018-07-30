using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;

namespace OYASAR.Penguin.Admin.Controllers
{
    [Route("api/[controller]")]
    [Authorize()]
    public class ShiftController : AbstractController<IShiftService>
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetShift();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{month}")]
        public IActionResult Get(string month)
        {
            var result = service.GetShift(month);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = service.GetShift(id);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Shift value)
        {
            service.AddNewShift(value);
        }

        // PUT api/values/5
        [HttpPut("{firstShiftId}/{secondShiftId}")]
        public void Put(int firstShiftId, int secondShiftId)
        {
            service.ChangeShift(firstShiftId, secondShiftId);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
