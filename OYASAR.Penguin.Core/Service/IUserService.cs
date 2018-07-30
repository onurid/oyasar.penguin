using OYASAR.Framework.Core.Interface;
using OYASAR.Penguin.Core.Model;

namespace OYASAR.Penguin.Core.Service
{
    public interface IUserService : ITransientDependency
    {
        bool CreateOrLogin(User user);
        bool Modify(User user);
        bool Delete();
        bool Login(User user);
    }
}