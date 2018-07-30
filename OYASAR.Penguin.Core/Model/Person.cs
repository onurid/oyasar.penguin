using System.Collections.Generic;

namespace Penugin.Core.Model
{
    public class Person
    {
        public int OrderNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Staff { get; set; }
        public string Education { get; set; }
        public string Status { get; set; }
        public IList<string> Days { get; set; } = new List<string>();
    }
}