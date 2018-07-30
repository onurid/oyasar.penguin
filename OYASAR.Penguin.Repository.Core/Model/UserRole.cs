using OYASAR.Penguin.Repository.Core.Base;

namespace OYASAR.Penguin.Repository.Core.Model
{
    public class UserRole : BaseAuditModify<int>
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual User User { get; set; }
    }
}
