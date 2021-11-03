using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Students
{
    struct Student
    {
        public string name;
        public string surname;
        public int bornYear;
        public string exam;
        public int ball;
        public Student(string[] s)
        {
            this.surname = s[0];
            this.name = s[1];
            int x = 1;
            if (!Int32.TryParse(s[2], out x))
            {
                Console.WriteLine($"У студента неверный ввод года рождения");
            }
            this.bornYear = x;
            x = 0;
            this.exam = s[3];
            if (!Int32.TryParse(s[4], out x))
            {
                Console.WriteLine($"У студента неверно введены баллы");
            }
            this.ball = x;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{surname} {name} {bornYear}: {exam} — {ball}");
        }
    }
    class Program
    {

        public static void NewStudent(Dictionary<int,Student> students)
        {
            Console.WriteLine("Введите фамилию, имя, год рождения, экзамен, баллы студента через пробел: ");
            string s = Console.ReadLine();
            string[] splitted = s.Split(' ');
            Student current = new Student(splitted);
            students.Add(students.Count,current);
        }
        static void Main(string[] args)
        {
            string path = "1.txt";
            string[] text = File.ReadAllLines(path,Encoding.GetEncoding(1251));
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            int i = 0; //Key Value
            foreach (string s in text)
            {
                string[] splitted = s.Split(' ');
                Student current = new Student();
                current.surname = splitted[0];
                current.name = splitted[1];
                int x = 1;
                if (!Int32.TryParse(splitted[2], out x))
                {
                    Console.WriteLine($"У студента {i} неверный ввод года рождения");
                }
                current.bornYear = x;
                x = 0;
                current.exam = splitted[3];
                if (!Int32.TryParse(splitted[4],out x))
                {
                    Console.WriteLine($"У студента {i} неверно введены баллы");
                }
                current.ball = x;
                students.Add(i, current);
                i++;
            }   //Считывание с файла
            NewStudent(students);

            foreach (KeyValuePair<int, Student> item in students)
            {
                Console.Write((item.Key + 1)+" ");
                item.Value.DisplayInfo();
            }
            Console.ReadKey();
        }
    }
}
