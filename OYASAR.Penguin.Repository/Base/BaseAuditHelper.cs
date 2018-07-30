using OYASAR.Framework.Utils.Helper;
using OYASAR.Penguin.Repository.Core.Base;
using System;

namespace OYASAR.Penguin.Repository.Base
{
    public class BaseAuditHelper<K, I>
    {
        public int SystemUserId { get; set; } = 1;

        public enum BaseAuditType
        {
            Create = 0,
            Modify = 1,
            Delete
        }

        public BaseAuditHelper(K k, BaseAuditType baseAuditType, bool isNew = false)
        {
            if (TypeHelper.IsAssignableFrom(typeof(K), typeof(BaseAuditModify<I>)) && baseAuditType == BaseAuditType.Modify)
            {
                var modifyData = k as BaseAuditModify<I>;
                modifyData.ModifiedDate = DateTime.Today;
                modifyData.ModifiedBy = SystemUserId;
                if (isNew)
                {
                    modifyData.CreatedDate = DateTime.Today;
                    modifyData.CreatedBy = SystemUserId;
                }
            }

            if (TypeHelper.IsAssignableFrom(typeof(K), typeof(BaseAuditCreate<I>)) && baseAuditType == BaseAuditType.Create && isNew)
            {
                var modifyData = k as BaseAuditCreate<I>;
                modifyData.CreatedDate = DateTime.Today;
                modifyData.CreatedBy = SystemUserId;
            }

            if (TypeHelper.IsAssignableFrom(typeof(K), typeof(BaseAuditDelete<I>)) && baseAuditType == BaseAuditType.Delete)
            {
                var modifyData = k as BaseAuditDelete<I>;
                modifyData.DeleteddDate = DateTime.Today;
                modifyData.DeletedBy = SystemUserId;
            }
        }
    }
}
