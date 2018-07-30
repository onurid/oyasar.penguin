using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OYASAR.Framework.Core.Utils;
using OYASAR.Framework.EPPlus;
using OYASAR.Penguin.Core.Service;
using Penugin.Core.Model;

namespace OYASAR.Penguin.Business
{
    public class ExcelService : IExcelService
    {
        public IList<Person> ReadToMainTable()
        {
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            var excelReader = new ExcelReader($"{filePath}/Data/watchlist.xlsx");

            var matrix = new Matrix(1, 5, 1, 20);

            var result = excelReader.ReadExcel(1, matrix);
            
            var personList = new List<Person>();
            var person = new Person();

            var k = 1;
            
            for (var i = 1; i <= matrix.MatrixColumnCount; i++)
            {
                FillPerson(result[k, i], i, person);
                if (i == matrix.MatrixColumnCount && k < matrix.MatrixRowCount)
                {
                    k++;
                    i = 0;
                    personList.Add(person);
                    person = new Person();
                }
            }

            return personList;
        }

        private static void FillPerson(object value, int j, Person person)
        {
            switch (j)
            {
                case 1:
                    person.OrderNo = Convert.ToInt32(value);
                    break;
                case 2:
                    FillNameSurname(value, person);
                    break;
                case 3:
                    person.Title = value?.ToString();
                    break;
                case 4:
                    person.Staff = value?.ToString();
                    break;
                case 5:
                    person.Education = value?.ToString();
                    break;
                case 6:
                    person.Status = value?.ToString();
                    break;
                default:
                    person.Days.Add(value?.ToString());
                    break;
            }
        }

        private static void FillNameSurname(object value, Person person)
        {
            if (value != null)
            {
                var values = value.ToString().Split(' ');
                person.Name = values.First();
                person.Surname = values.Last();
            }
        }

        public void WriteToExell(IList<Person> personList)
        {
            throw new NotImplementedException();
        }
    }
}
