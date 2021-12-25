using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    class Brewery
    {
        public string Name { get; set; }
        private decimal Budget;
        private decimal Dolg = 0;
        public List<Equipment> Equipments;
        static int n = 10000;
        public Beer[] Sklad = new Beer[n];
        private int bochkaNum=0;
        public Brewery ()
        {
            Name = "Обычный";
            Budget = 10000;
        }
        public Brewery(string name)
        {
            this.Name = name;
            Budget = 10000;
        }
        public Brewery(decimal x)
        {
            Name = "Обычный";
            Budget = x;
        }
        public Brewery(string name,decimal x)
        {
            this.Name=name;
            Budget = x;
        }
        
        public void PayTaxes(decimal x)
        {
            if (x < Budget)
            {
                Budget -= x;
            }
            else
            {
                Console.WriteLine($"Долг {x}");
                Dolg += x;
            }
        }
        public void AddEquip(Equipment e)
        {
            if (e.price<Budget)
            {
                Budget -= e.price;
                Equipments.Add(e);
            }
            else
            {
                Console.WriteLine("денег нет");
            }
        }
        public void DeleteEquip(Equipment e)
        {
            if (Equipments.Contains(e))
            {
                Equipments.Remove(e);
            }
            else
            {
                Console.WriteLine("Нет такого");
            }
        }
        public void Brew(Filter filter, Type type)
        {
            Beer beer = new Beer(type, filter);
            if (bochkaNum >= n)
            {
                Sklad[bochkaNum++] = beer;
            }
            else
            {
                Console.WriteLine("Склад заполнен, пьем лишнее");
            }
        }

    }
}
