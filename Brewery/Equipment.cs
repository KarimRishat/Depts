using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery
{
    class Equipment
    {
        public enum Power { off,on}
        public string Name { get; }
        public string Model { get; }
        public decimal price { get; set; }
        public Power status;
        public Equipment()
        {
            Name = "Палка-копалка";
            Model = "A1.0";
            price = 1;
        }
        public Equipment(string name)
        {
            Name = name;
            Model = "A1.0";
            price = 1;
        }
        public Equipment(string name, string model)
        {
            Name = name;
            Model = model;
            price = 1;
        }
        public Equipment(string name, string model, decimal price)
        {
            Name = name;
            Model = model;
            this.price = price;
        }
        public void Work(Employee emp)
        {
            Console.WriteLine($"{emp.ToString()} works on {Name} модели {Model}");
        }
        public void Slomalsya()
        {
            Console.WriteLine($"{Name} {Model} сломался");
        }
        public void On()
        {
            status = Power.on;
        }
        public void Off()
        {
            status = Power.off;
        }
    }
}
