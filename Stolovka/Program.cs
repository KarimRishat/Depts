using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stolovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("\nЗадание 4.");
            Console.WriteLine("Количество работников и столов: ");
            int n, t;
            while (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Ошибка ввода. Попробуйте ещё раз.");
            }

            // создаю работников
            List<Worker> workers = new List<Worker>();
            Console.WriteLine("Порядок до обгонов:");
            for (int i = 0; i < n; i++)
            {
                workers.Add(new Worker($"_{rnd.Next(0, 1000)}_", (Post)rnd.Next(0, 3), rnd.Next(0, 11), Convert.ToBoolean(rnd.Next(0, 2))));
                Console.WriteLine(workers[i]);
            }

            // создание столов
            Stack<Table> tables = new Stack<Table>();
            for (int i = t; i > 0; i--)
            {
                tables.Push(new Table(i, (Color)rnd.Next(0, 9)));
            }

            // создание связи знакомств
            bool[,] mates = new bool[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        mates[i, j] = true;
                    }
                    else if (j < i)
                    {
                        mates[i, j] = mates[j, i];
                    }
                    else
                    {
                        mates[i, j] = Convert.ToBoolean(rnd.Next(0, 2));
                    }
                    Console.Write(Convert.ToInt32(mates[i, j]) + " ");
                }
                Console.WriteLine();
            }

            // расстановка в очереди, где i = 0 - её начало, i = n - конец
            for (int i = 0; i < n; i++)
            {
                if (workers[i].stupidity)
                {
                    if (workers[i].cheek == 0)
                    {
                        if (i >= 1)
                        {
                            workers.Insert(i - 1, workers[i]);
                            workers.RemoveAt(i + 1);
                        }
                    }
                    else
                    {
                        if (i >= workers[i].cheek)
                        {
                            workers.Insert(workers[i].cheek, workers[i]);
                            workers.RemoveAt(i + 1);
                        }
                        else
                        {
                            workers.Insert(0, workers[i]);
                            workers.RemoveAt(i + 1);
                        }
                    }
                }
            }
            Console.WriteLine($"После обгонов:\n{String.Join("\n", workers)}");

            // рассадка по столам
            for (int i = 0; i < n; i++) // перебираем всех работников
            {
                bool done = false;
                for (int j = 0; j < tables.Count; j++) // перебираем все столы
                {
                    foreach (Worker place in tables.ElementAt(j).places) // перебираю занятые места конкретного стола
                    {
                        if (mates[i, Array.IndexOf(workers.ToArray(), place)]
                            && (tables.ElementAt(j).places.Count < 3 || tables.ElementAt(j).places.Count == 3 && workers[i].cheek > 0)
                            && !workers[i].stupidity)
                        // если работники знакомы и если искомое условие верно
                        {
                            tables.ElementAt(j).places.Add(workers[i]); // то добавим туда нового работника
                            done = true;
                            break;
                        }
                    }
                    if (done) j = tables.Count;
                }
                if (!done) // если он всё же не сел
                {
                    for (int j = 0; j < tables.Count; j++) // снова перебирает столы
                    {
                        if (tables.ElementAt(j).places.Count == 0)
                        {
                            tables.ElementAt(j).places.Add(workers[i]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"Что же получается в итоге:\n{String.Join("\n", tables)}");
        }
    }
}
