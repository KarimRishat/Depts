using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Link
    {
        public Person start;
        public Person end;
        public int weight;
        public Link(Person chief, Person employee, int weight = 1)
        {
            start = chief;
            end = employee;
            this.weight = weight;
        }
    }
}
