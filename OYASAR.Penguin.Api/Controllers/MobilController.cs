using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OYASAR.Framework.Core.Interface;
using OYASAR.Framework.Core.Utils;
using OYASAR.Penguin.Core.Service;

namespace OYASAR.Penguin.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/mobil")]
    [Authorize()]
    public class MobilController : ControllerBase
    {
        private readonly IServiceFactory services;

        public MobilController()
        {
            services = Invoke<IServiceFactory>.Call();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(services.GetNurseService().GetNurse());
        }

        [HttpGet("{periodID}")]
        public IActionResult Get(int periodId)
        {
            return Ok(services.GetSihftService().GetShift(periodId));
        }
    }

    interface IServiceFactory : ITransientDependency
    {
        IUserService GetUserService();
        IShiftService GetSihftService();
        INurseService GetNurseService();
    }

    public class ServiceFactory : IServiceFactory
    {
        public INurseService GetNurseService()
        {
            return Invoke<INurseService>.Call();
        }

        public IShiftService GetSihftService()
        {
            return Invoke<IShiftService>.Call();
        }

        public IUserService GetUserService()
        {
            return Invoke<IUserService>.Call();
        }
    }
}