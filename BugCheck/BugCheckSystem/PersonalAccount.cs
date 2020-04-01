using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class PersonalAccount
    {
        public int Id { get; set; }

        public Employee Employee { get; set; }

        public string Username { get; set; }

        public PersonalAccount() { }

        public PersonalAccount(string username, Employee e)
        {
            Username = username;
            Employee = e;
        }

    }
}
