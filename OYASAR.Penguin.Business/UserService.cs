using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;
using static OYASAR.Penguin.Core.Constant;

namespace OYASAR.Penguin.Business
{
    public class UserService : IUserService
    {
        public bool CreateOrLogin(User user)
        {
            //switch (user.State)
            //{
            //    case State.Create: return Create(user);
            //    case State.Get: return Login(user);

            //    default: return false;
            //}

            return false;
        }

        public bool Delete()
        {
            return true;
        }

        public bool Modify(User user)
        {
            return true;
        }

        private bool Create(User user)
        {
            return true;
        }

        public bool Login(User user)
        {
            return true;
        }
    }
}