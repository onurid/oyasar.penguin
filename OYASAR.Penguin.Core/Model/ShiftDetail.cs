using System;

namespace OYASAR.Penguin.Core.Model
{
    public class ShiftDetail : Base
    {
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

        public virtual Shift Shift { get; set; }
    }
}
