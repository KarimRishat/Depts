using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lottery
{
    class Program
    {
        static Random random = new Random();
        private const string PathToStudentFile = @"student.txt";
        static void Main(string[] args)
        {
            SetListStudentsFromFile(out List<Student> students);
            List<Lotery> loteries = new List<Lotery>()
            {
              new Lotery("Билеты в Театр", DateTime.Today.AddDays(7), 6),
              new Lotery("Билеты в Кино", DateTime.Today.AddDays(14), 10),
              new Lotery("Билеты на Концерт", DateTime.Today.AddDays(21), 4),
              new Lotery("Билеты в Армию", DateTime.Today.AddDays(28), 12)
            };
            for (int i = 0; i < loteries.Count; i++)
            {
                loteries[i].Start(GetListPossibleParticipants(students));
            }
            foreach (var item in loteries)
            {
                item.Display();
            }

        }
        static void SetListStudentsFromFile(out List<Student> students)
        {
            students = new List<Student>();
            using (StreamReader reader = new StreamReader(PathToStudentFile,Encoding.GetEncoding(1251)))
            {
                string stringfromfile;
                while ((stringfromfile = reader.ReadLine()) != null)
                {

                    string[] dateStudent = stringfromfile.Split();
                    string nameStudent = dateStudent[0];
                    if (!int.TryParse(dateStudent[1], out int numberStudent))
                    {
                        throw new FormatException("Неправильный номер студента");
                    }
                    students.Add(new Student(nameStudent, numberStudent));
                }
            }
        }
        static List<Student> GetListPossibleParticipants(List<Student> students)
        {
            return new List<Student>(from u in students where random.Next(100) < 50 select u);
        }
    }
}
