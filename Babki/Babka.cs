using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babki
{
    class Babka
    {
        int age;
        string name;
        public List <Disease> dis = new List<Disease>();
        public Babka(string name, int age, List<Disease> diseases)
        {
            this.name = name;
            this.age = age;
            foreach (var item in diseases)
            {
                dis.Add(item);
            }
        }
        public override string ToString()
        {
            return $"Баба {name}, {age}лет";
        }
    }
}
