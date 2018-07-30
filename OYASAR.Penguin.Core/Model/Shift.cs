using System.Collections.Generic;

namespace OYASAR.Penguin.Core.Model
{
    public class Shift : Base
    {
        public string Month { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual IList<ShiftDetail> ShiftDetails { get; set; }        
    }
}
