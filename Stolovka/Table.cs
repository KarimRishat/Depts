using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stolovka
{
    class Table
    {
        public int serial;
        public Color color;
        public List<Worker> places;
        public Table(int serial, Color color)
        {
            this.serial = serial;
            this.color = color;
            this.places = new List<Worker>();
        }
        public override string ToString()
        {
            return $"{serial}-{color}: {String.Join(" ", places)}";
        }
    }
}
