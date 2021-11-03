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
        public Student(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
            bornYear = 1999;
            exam = "math";
            ball = 100;
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
        public static void DeleteStudent(Dictionary<int, Student> studs)
        {
            Console.WriteLine("Введите Фамилию и Имя: ");
            string s = Console.ReadLine();
            string[] splitted = s.Split(' ');
            Student stud = new Student(splitted[0],splitted[1]);
            stud.DisplayInfo();
            int key = studs.Count+1;
            foreach(KeyValuePair<int, Student> item in studs)
            {
                if (item.Value.surname.Equals(stud.surname) && item.Value.name.Equals(stud.name))
                {
                    key = item.Key;
                }
            }
            if (key != studs.Count+1)
            {
                studs.Remove(key);
            }
            else
            {
                Console.WriteLine("Нет Такого студента");
            }
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
                Student current = new Student(splitted);
                students.Add(i, current);
                i++;
            }   //Считывание с файла
           
            foreach (KeyValuePair<int, Student> item in students)
            {
                Console.Write((item.Key + 1)+" ");
                item.Value.DisplayInfo();
            }
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nМеню:\n1.Введите 'Новый студент', чтобы добавить студента\n" +
                "2.Введите 'Удалить', чтобы удалить студента\n" +
                "3.Введите 'Сортировать', чтобы отсортировать по баллам\n" +
                "4.Введите 'Завершить', чтобы завершить программу");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "Новый студент":
                        NewStudent(students);
                        break;
                    case "Удалить":
                        DeleteStudent(students);
                        break;
                    case "Сортировать":
                        students = students.OrderBy(pair => pair.Value.ball).ToDictionary(pair => pair.Key, pair => pair.Value);
                        Console.WriteLine("\nSorted:");
                        foreach (KeyValuePair<int, Student> item in students)
                        {
                            Console.Write((item.Key + 1) + " ");
                            item.Value.DisplayInfo();
                        }
                        break;
                    case "Завершить":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
