using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Hierarchy myHierarchy = new Hierarchy();

            Person p1 = new Person("Boris", Department.Director, Job.Chief);
            Person p2 = new Person("Rashid", Department.Accounting, Job.Chief);
            Person p3 = new Person("Lukas", Department.Accounting, Job.Head);
            Person p4 = new Person("O Ilkham", Department.IT, Job.Chief);
            Person p5 = new Person("Orkadiy", Department.IT, Job.Head);
            Person p6 = new Person("Volodya", Department.IT, Job.Deputechief);
            Person p7 = new Person("Il'shat", Department.IT, Job.Head);
            Person p8 = new Person("Ivanych", Department.IT, Job.Deputechief);
            Person p9 = new Person("Ser_gey", Department.IT, Job.Head);
            Person p10 = new Person("Leysan", Department.IT, Job.Deputechief);
            Person p11 = new Person("Il'ya", Department.IT, Job.Systemer);
            Person p12 = new Person("Vitya", Department.IT, Job.Systemer);
            Person p13 = new Person("Genya", Department.IT, Job.Systemer);
            Person p14 = new Person("Marat", Department.IT, Job.Developer);
            Person p15 = new Person("Dina", Department.IT, Job.Developer);
            Person p16 = new Person("Il'dar", Department.IT, Job.Developer);
            Person p17 = new Person("Anton", Department.IT, Job.Developer);

            myHierarchy.AddPerson(p1);
            myHierarchy.AddPerson(p2);
            myHierarchy.AddPerson(p3);
            myHierarchy.AddPerson(p4);
            myHierarchy.AddPerson(p5);
            myHierarchy.AddPerson(p6);
            myHierarchy.AddPerson(p7);
            myHierarchy.AddPerson(p8);
            myHierarchy.AddPerson(p9);
            myHierarchy.AddPerson(p10);
            myHierarchy.AddPerson(p11);
            myHierarchy.AddPerson(p12);
            myHierarchy.AddPerson(p13);
            myHierarchy.AddPerson(p14);
            myHierarchy.AddPerson(p15);
            myHierarchy.AddPerson(p16);
            myHierarchy.AddPerson(p17);

            myHierarchy.CreateLinks();
            myHierarchy.AddLink(p1, p2);    //Борис босс
            myHierarchy.AddLink(p1, p4);
            myHierarchy.AddLink(p2, p3);
            myHierarchy.AddLink(p4, p5);
            myHierarchy.AddLink(p4, p6);
            myHierarchy.AddLink(p5, p7);
            myHierarchy.AddLink(p6, p7);
            myHierarchy.AddLink(p7, p8);
            myHierarchy.AddLink(p5, p9);
            myHierarchy.AddLink(p6, p9);
            myHierarchy.AddLink(p9, p10);
            myHierarchy.AddLink(p7, p11);   //системщики
            myHierarchy.AddLink(p7, p12);
            myHierarchy.AddLink(p7, p13);
            myHierarchy.AddLink(p8, p11);
            myHierarchy.AddLink(p8, p12);
            myHierarchy.AddLink(p8, p13);
            myHierarchy.AddLink(p9, p14);   //разрабы
            myHierarchy.AddLink(p9, p15);
            myHierarchy.AddLink(p9, p16);
            myHierarchy.AddLink(p9, p17);
            myHierarchy.AddLink(p10, p14);
            myHierarchy.AddLink(p10, p15);
            myHierarchy.AddLink(p10, p16);
            myHierarchy.AddLink(p10, p17);
            myHierarchy.ShowAdjList();

            Task task1 = new Task(p1, p9, "Задание1");
            Task task2 = new Task(p8, p11, "Задание2");
            Task task3 = new Task(p2, p4, "Задание3");
            Task task4 = new Task(p2, p17, "Задание4");
            Task task5 = new Task(p3, p10, "Задание5");
            Task task6 = new Task(p6, p8, "Задание6");

            List<Task> tasks = new List<Task>();
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6);

            foreach (Task t in tasks)
            {
                Console.WriteLine($"\n{t.chief.name} дает задачу {t.descr} сотруднику {t.employee.name}");
                bool flag = false;
                foreach (Person p in myHierarchy.links[t.chief.id])
                {
                    if (p == t.employee)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("задача принята");
                }
                else
                {
                    Console.WriteLine("задача не принята");
                }
            }
        }
    }
}
