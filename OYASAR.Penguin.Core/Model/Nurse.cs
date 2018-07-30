using System.Collections.Generic;

namespace OYASAR.Penguin.Core.Model
{
    public class Nurse : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Staff { get; set; }
        public string Education { get; set; }
        public string Status { get; set; }
        
        public virtual IList<Shift> Shifts { get; set; }
    }
}
