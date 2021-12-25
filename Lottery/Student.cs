using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Student
    {
        private static int count = 0;
        public int ID { get; private set; }
        public byte NumWins { get; private set; }
        public string Name { get; private set; }
        public int NumGroup { get; private set; }

        public Student(string name, int numberGroup)
        {
            Name = name;
            NumGroup = numberGroup;
            ID = count;
            count++;
        }
        public void WinLotery()
        {
            NumWins++;
        }
        public override string ToString()
        {
            return $"{ID} {Name} {NumGroup} Количество выйгрешей: {NumWins}";
        }
    }
}
