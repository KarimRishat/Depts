using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public enum Department { Director, Accounting, IT}
    public enum Job {Chief, Accounter, Head, Deputechief, Systemer, Developer }
    class Person
    {
        private static int number = 0;
        public string name { get; set; }
        public int id;
        public Job job;
        public Department dep;
        public Person(string name, Department dep, Job job)
        {
            this.name = name;
            id = number++;
            this.dep = dep;
            this.job = job;
        }
    }
}
