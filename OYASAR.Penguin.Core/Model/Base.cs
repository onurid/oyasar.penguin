using OYASAR.Framework.Core.Entity;
using static OYASAR.Penguin.Core.Constant;

namespace OYASAR.Penguin.Core.Model
{
    public class Base : Entity<int>
    {
        public State State { get; set; }
    }
}
