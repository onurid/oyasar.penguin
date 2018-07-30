using OYASAR.Framework.Core.Entity;
using System;

namespace OYASAR.Penguin.Repository.Core.Base
{
    public abstract class BaseAudit<T> : Entity<T>
    {

    }

    public abstract class BaseAuditCreate<T> : BaseAudit<T>
    {
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

    public abstract class BaseAuditModify<T> : BaseAuditCreate<T>
    {
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public abstract class BaseAuditDelete<T> : BaseAuditModify<T>
    {
        public int? DeletedBy { get; set; }
        public DateTime? DeleteddDate { get; set; }
    }
}
