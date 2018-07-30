using OYASAR.Penguin.Repository.Core.Base;

namespace OYASAR.Penguin.Repository.Core.Model
{
    public class ContactInfo : BaseAuditModify<int>
    {
        public int UserId { get; set; }
        public int? CompanyId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
