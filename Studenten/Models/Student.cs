using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Studenten.Models
{
    public class Student : IComparable<Student>
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public int CompareTo(Student other)
        {
            return this.Leeftijd.CompareTo(other.Leeftijd);
        }
    }

}
