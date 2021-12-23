using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Hierarchy
    {
        private List<Person> V = new List<Person>();
        private List<Link> E = new List<Link>();
        public List<Person>[] links;
        public int peopleCount => V.Count;
        public void CreateLinks()
        {
            links = new List<Person>[peopleCount];
            for (int i = 0; i < peopleCount; i++)
            {
                links[i] = new List<Person>();
            }
        }
        public void AddPerson(Person v)
        {
            V.Add(v);
        }
        public void AddLink(Person chief, Person employee)
        {
            Link e = new Link(chief, employee);
            E.Add(e);
            links[chief.id].Add(employee);
        }
        public void ShowAdjList()
        {
            for (int i = 0; i < peopleCount; i++)
            {
                Console.Write(i + ": ");
                foreach (Person v in links[i])
                {
                    Console.Write(v.name + ", ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
