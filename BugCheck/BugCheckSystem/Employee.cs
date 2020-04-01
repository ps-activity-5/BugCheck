using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public Employee() { }

        public Employee(string x, string y, string z)
        {
            Firstname = x;
            Surname = y;
            Position = z;
        }
    }
}
