using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    class Employee:Person
    {
        public Employee()
            : base()
        { }
        public Employee(string name)
            : base(name)
        { }
        public Employee(string name, string name2)
            : base(name, name2)
        { }
        public Employee(string name, string name2, int a)
            : base(name, name2, a)
        { }
        public void ChangeSalary(decimal x)
        {
            this.Salary = x;
        }
        public void Work(Equipment e)
        {
            Console.WriteLine(firstName+"Пошел работать");
            e.Work(this);
        }
        public void CheckBeer()
        {
            Console.WriteLine("Проверил на вкус");
        }
        public void Repair(Equipment e)
        {
            Console.WriteLine($"{firstName} чинит {e.Name}");
        }
        public void Obed()
        {
            Console.WriteLine("Пошел на обед");
        }
    }
}
