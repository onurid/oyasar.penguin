using System;
using System.Collections.Generic;
using System.Linq;
using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;

namespace OYASAR.Penguin.Business
{
    public class ShiftService : IShiftService
    {
        public void AddNewShift(Shift shift)
        {
            throw new NotImplementedException();
        }

        public bool ChangeShift(int firstshiftId, int secondShiftId)
        {
            throw new NotImplementedException();
        }

        public IList<Shift> GetAllShift()
        {
            return new List<Shift> {
                new Shift { 
                Month = "Ocak", 
                Nurse = new Nurse { Name = "Test" }, 
                ShiftDetails = new List<ShiftDetail> {
                    new ShiftDetail { ShiftStart = DateTime.Today, ShiftEnd = DateTime.Today.AddDays(1) },
                    new ShiftDetail { ShiftStart = DateTime.Today.AddDays(2), ShiftEnd = DateTime.Today.AddDays(3) }
                }},
                new Shift { 
                Month = "Şubat", 
                Nurse = new Nurse { Name = "Test22222" }, 
                ShiftDetails = new List<ShiftDetail> {
                    new ShiftDetail { ShiftStart = DateTime.Today, ShiftEnd = DateTime.Today.AddDays(1) },
                    new ShiftDetail { ShiftStart = DateTime.Today.AddDays(2), ShiftEnd = DateTime.Today.AddDays(3) }
                }}
            };
        }

        public Shift GetShift(int nurseId)
        {
            return GetAllShift().First();
        }

        public Shift GetShift(string month)
        {
            return GetAllShift().First();
        }

        public Shift GetShift()
        {
            return GetAllShift().First();
        }
    }
}