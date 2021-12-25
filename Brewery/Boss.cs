using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    class Boss: Person
    {
        public Boss()
            : base()
        { }
        public Boss(string name)
            :base(name)
        { }
        public Boss(string name, string name2)
            : base(name,name2)
        { }
        public Boss(string name, string name2, int a)
            : base(name, name2, a)
        { }
        private List<Employee> employees = new List<Employee>();
        public void ChangeSalary(Employee emp, decimal x)
        {
            emp.ChangeSalary(x);
        }
        public void DeleteEmp(Employee emp)
        {
            if(employees.Contains(emp))
            {
                employees.Remove(emp);
            }
            else
            {
                Console.WriteLine("Нет такого");
            }
        }
        public void AddEmp(Employee emp)
        {
            employees.Add(emp);
        }
        public void Sobranie()
        {
            Console.WriteLine("Собрание");
        }
    }
}
