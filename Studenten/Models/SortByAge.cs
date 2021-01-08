using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenten.Models
{
        public class SortByAge : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return x.Leeftijd.CompareTo(y.Leeftijd);
            }
        }
}
