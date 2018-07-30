using OYASAR.Framework.Core.Interface;
using OYASAR.Penguin.Core.Model;
using Penugin.Core.Model;
using System.Collections.Generic;

namespace OYASAR.Penguin.Core.Service
{
    public interface INurseService : ITransientDependency
    {
        bool AddNewNurse(Nurse nurse);
        void AddNewNurse(Person person);
        void AddNewNurse(string name, string surname);
        Nurse GetNurse(int nurseId);
        Nurse GetNurse();
        IList<Nurse> GetNurses(string name);
        void DeleteNurse(int nurseId);        
    }
}
