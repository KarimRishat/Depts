using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("Гарник", "Абгарян",28);
            Brewery brewery1 = new Brewery("3 Татарина", 100000);
            Employee e1 = new Employee();
            Employee e2 = new Employee("rimus");
            Employee e3 = new Employee("Albus", "Dumbledore");
            boss.AddEmp(e1);
            boss.AddEmp(e2);
            boss.AddEmp(e3);
            Equipment t1 = new Equipment();
            Equipment t2 = new Equipment("Аппарат","A12",1000);
            Equipment t3 = new Equipment("Аппарат","B57",2000);
            brewery1.AddEquip(t1);
            brewery1.AddEquip(t2);
            brewery1.AddEquip(t3);
            t1.Work(e1);
            t2.Slomalsya();
            e2.Repair(t2);
            
        }
    }
}
