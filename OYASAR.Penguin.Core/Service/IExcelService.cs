using OYASAR.Framework.Core.Interface;
using Penugin.Core.Model;
using System.Collections.Generic;

namespace OYASAR.Penguin.Core.Service
{
    public interface IExcelService : ITransientDependency
    {
        IList<Person> ReadToMainTable();

        void WriteToExell(IList<Person> personList);
    }
}
