using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babki
{
    class Hospital
    {
        public string name;
        public int capacity = 1;
        public List<Medicine> MedList= new List<Medicine>();
        public Babka[] babkas;
        public Hospital(string name, List<Medicine> list, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            MedList = list;
            this.babkas = new Babka[capacity];
        }
        
    }
}
