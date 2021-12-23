using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Task
    {
        public Person chief;
        public Person employee;
        public string descr;
        public Task(Person chief, Person employee, string descr)
        {
            this.chief = chief;
            this.employee = employee;
            this.descr = descr;
        }
    }
}
