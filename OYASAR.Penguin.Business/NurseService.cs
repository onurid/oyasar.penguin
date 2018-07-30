using System;
using System.Collections.Generic;
using System.Linq;
using OYASAR.Penguin.Core.Model;
using OYASAR.Penguin.Core.Service;
using Penugin.Core.Model;

namespace OYASAR.Penguin.Business
{
    public class NurseService : INurseService
    {
        public bool AddNewNurse(Nurse nurse)
        {
            throw new System.NotImplementedException();
        }

        public void AddNewNurse(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void AddNewNurse(string name, string surname)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteNurse(int nurseId)
        {
            throw new System.NotImplementedException();
        }

        public Nurse GetNurse(int nurseId)
        {
            return GetNurses(null).First();
        }

        public Nurse GetNurse()
        {
            return GetNurses(null).First();
        }

        public IList<Nurse> GetNurses(string name)
        {
            return new List<Nurse> {
                new Nurse { Name = "Ahmet", Title = "Hemşire", Shifts = new List<Shift> { 
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
                 } }
            };
        }
    }
}