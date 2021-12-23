using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babki
{
    enum Disease {Sprosit, RespiratoryInfection, Tuberculosis, AIDS, Diabetes, Arthritis }
    enum Medicine {Priem, RespMed, TuberMed, AIDSMed, DiabMed, ArthMed}
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Babka> babkas = new Queue<Babka>();
            List<Disease> diseases = new List<Disease>();
            diseases.Add(Disease.AIDS);
            diseases.Add(Disease.Arthritis);
            diseases.Add(Disease.RespiratoryInfection);
            diseases.Add(Disease.Diabetes);
            Babka nura = new Babka("Nura", 80, diseases);
            babkas.Enqueue(nura);
            diseases.Clear();
            diseases.Add(Disease.AIDS);
            diseases.Add(Disease.Arthritis);
            Babka shura = new Babka("SHura", 69, diseases);
            babkas.Enqueue(shura);
            diseases.Clear();
            diseases.Add(Disease.Tuberculosis);
            Babka roza = new Babka("ROZA", 75, diseases);
            
            babkas.Enqueue(roza);
            diseases.Clear();
            Dictionary<Disease, Medicine> receipt = new Dictionary<Disease, Medicine>();
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                receipt.Add((Disease)i, (Medicine)i);
            }
            Stack<Hospital> hospitals = new Stack<Hospital>();
            List<Medicine> medicines = new List<Medicine>();
            medicines.Add(Medicine.Priem);
            medicines.Add(Medicine.DiabMed);
            medicines.Add(Medicine.TuberMed);
            Hospital hospit1 = new Hospital("1", medicines, 1);
            medicines.Clear();
            medicines.Add(Medicine.Priem);
            medicines.Add(Medicine.DiabMed);
            medicines.Add(Medicine.TuberMed); 
            medicines.Add(Medicine.RespMed);
            medicines.Add(Medicine.AIDSMed);
            Hospital hospit2 = new Hospital("2", medicines, 1);
            medicines.Clear();
            medicines.Add(Medicine.RespMed);
            medicines.Add(Medicine.Priem);
            Hospital hospit3 = new Hospital("3", medicines, 3);
            hospitals.Push(hospit1);
            hospitals.Push(hospit2);
            hospitals.Push(hospit3);
            Queue<Babka> babkasTMP = new Queue<Babka>(babkas);
            Stack<Hospital> hospitalsTmp = new Stack<Hospital>(hospitals);
            int hospCount = hospitals.Count;
            for (int i = 0; i < hospCount; i++)
            {
                Hospital hospital = hospitals.Pop();
                int place = 0;
                
                while (place<hospital.capacity && babkas.Count > 0)
                {
                    Babka babka = babkas.Dequeue();
                    int countDIS = 0;
                    foreach (Disease dis in babka.dis)
                    {
                        Medicine med = new Medicine();
                        if (receipt.TryGetValue(dis,out med))
                        {
                            if (hospital.MedList.Contains(med))
                            {
                                countDIS++;
                            }
                        }
                    }
                    if ((double)countDIS/babka.dis.Count >= 0.5)
                    {
                        hospital.babkas[place] = babka;
                        place++;
                    }
                    //babkasTMP.Enqueue(babka);
                }
                foreach (Babka item in babkasTMP)
                {
                    babkas.Enqueue(item);
                }
                //hospitalsTmp.Push(hospital);
            }
            for (int i = 0; i < hospitalsTmp.Count; i++)
            {
                Hospital hosp = hospitalsTmp.Pop();
                Console.WriteLine($"В больнице {hosp.name} с вместимостью {hosp.capacity} лежат:");
                foreach (Babka babka in hosp.babkas)
                {
                    Console.WriteLine(babka);
                }
            } 
            
        }
    }
}
