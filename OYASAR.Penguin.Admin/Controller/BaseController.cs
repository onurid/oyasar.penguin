using Microsoft.AspNetCore.Mvc;
using OYASAR.Framework.Core.Utils;
using OYASAR.Penguin.Core.Service;

namespace OYASAR.Penguin.Admin.Controllers
{
    [Produces("application/json")]
    [Route("api/Base")]
    public abstract class AbstractController<T> : ControllerBase where T: class
    {
        protected T service;

        public AbstractController()
        {
            service = Invoke<T>.Call();
        }
    }

    public interface ServiceFactory
    {
        IUserService GetUserService();
        IShiftService GetSihftService();
        INurseService GetNurseService();
    }

    [Produces("application/json")]
    [Route("api/Base")]
    public abstract class AbstractController : ControllerBase
    {
        protected ServiceFactory services;

        public AbstractController()
        {
            services = Invoke<ServiceFactory>.Call();
        }
    }
}