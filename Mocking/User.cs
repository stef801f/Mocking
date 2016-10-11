using System;
using System.Collections.Generic;

namespace Mocking
{
    public class User
    {
        public User()
        {
        }

        public string Password { get; set; }
        public object Rights { get; internal set; }
        public string UserName { get; set; }
        public int NumMessagesCreated { get; set; }

        public List<Employee> employees = new List<Employee>();

        internal string ViewAllEmployees()
        {
            return ("Here is the list");
        }


        internal void EditEmployeeName(Employee e, string v)
        {
            e.Name = v;
           

        }
    }
}