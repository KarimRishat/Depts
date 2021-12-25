using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    abstract class Person
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int Age { get; set; }
        protected decimal Salary { get; set; }
        
        public Person()
        {
            firstName = "Неизвестный";
            secondName = "Неизвестный";
            Age = 18;
        }
        public Person(string name)
        {
            firstName = name;
            secondName = "Неизвестный";
            Age = 18;
        }
        public Person(string name, string name2)
        {
            firstName = name;
            secondName = name2;
            Age = 18;
        }
        public Person(string name, string name2, int a)
        {
            firstName = name;
            secondName = name2;
            Age = a;
        }
        public override string ToString()
        {
            return $"Имя {firstName}, Фамилия {secondName}";
        }
    }
}
