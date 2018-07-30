using System.Collections.Generic;
using OYASAR.Framework.Core.Interface;
using OYASAR.Penguin.Core.Model;

namespace OYASAR.Penguin.Core.Service
{
    public interface IShiftService : ITransientDependency
    {
        bool ChangeShift(int firstShiftId, int secondShiftId);
        void AddNewShift(Shift shift);
        Shift GetShift(string month);
        Shift GetShift();
        IList<Shift> GetAllShift();
        Shift GetShift(int shiftId);
    }
}
