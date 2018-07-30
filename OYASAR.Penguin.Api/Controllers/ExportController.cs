using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OYASAR.Penguin.Core.Service;
using Penugin.Core.Model;
using OYASAR.Framework.Core.Utils;

namespace OYASAR.Penguin.Api.Controllers
{
    [Route("api/[controller]")]
    public class ExportController : ControllerBase
    {
        private readonly IExcelService service;

        public ExportController()
        {
            service = Invoke<IExcelService>.Call();
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var list = service.ReadToMainTable();
            return Ok(list);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]IList<Person> value)
        {
            service.WriteToExell(value);
        }
    }
}