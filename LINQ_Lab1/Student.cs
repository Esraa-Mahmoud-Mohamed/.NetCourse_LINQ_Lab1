using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lab1
{
    internal class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Subject[] subjects { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int NoOfSubjects()
        {
            return subjects.Length;
        }

    }
}
