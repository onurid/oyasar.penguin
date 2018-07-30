using OYASAR.Framework.Core.Interface;
using OYASAR.Framework.Core.Utils;

namespace OYASAR.Penguin.Repository.Mapping
{
    public class MappingSettings
    {
        private readonly IMapper mapper;

        public MappingSettings()
        {
            this.mapper = Invoke<IMapper>.Call();
        }

        public void Register()
        {
            //mapper.RegisterMap<Core.Model.User, HotelBoss.Core.Domain.User.User>();
        }
    }
}
