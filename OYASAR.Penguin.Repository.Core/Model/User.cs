using OYASAR.Penguin.Repository.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OYASAR.Penguin.Repository.Core.Model
{
    public class User : BaseAuditModify<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastLogindate { get; set; }

        public virtual IList<UserRole> UserRoles { get; set; }
    }
}
