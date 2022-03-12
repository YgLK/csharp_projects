using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task7
    {

        class Student
        {
            private string nazwaKierunku;
            private int rokStudiow;
            private Dictionary<string, float> ocenyEgzamin = new Dictionary<string, float>();

            public Student(string kier, int rok, Dictionary<string, float> oceny)
            {
                NazwaKierunku = kier;
                RokStudiow = rok;
                OcenyEgzamin = oceny;
            }

            public string NazwaKierunku { get => nazwaKierunku; set => nazwaKierunku = value; }
            public int RokStudiow { get => rokStudiow; set => rokStudiow = value; }
            public Dictionary<string, float> OcenyEgzamin { get => ocenyEgzamin; set => ocenyEgzamin = value; }

            public void printExamGrades()
            {
                foreach (KeyValuePair<string, float> kvp in this.OcenyEgzamin)
                {
                    Console.WriteLine("     Przedmiot: {0}\n        Ocena: {1}\n", kvp.Key, kvp.Value);
                }
            }
        }

        ArrayList studenci;

        public Task7()
        {
            studenci = new ArrayList();
        }

        
        public void task7()
        {
            bool isValid = true;
            while (isValid)
            {
                Console.WriteLine("Komendy: \n add - dodaj studenta\n show - pokaz studentow\n exit - wyjscie");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "add":
                        dodajStudenta();
                        break;

                    case "show":
                        wyswietlStudentow();
                        break;

                    case "exit":
                        isValid = false;
                        break;
                }
            }
        }

        public void dodajStudenta()
        {
            Console.WriteLine("Podaj kierunek:");
            string kierunek = Console.ReadLine();
            Console.WriteLine("Podaj rok studiów:");
            int rokStudiow = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ile ocen egzaminow:");
            int n = Int32.Parse(Console.ReadLine());
            Dictionary<string, float> egzaminy = new Dictionary<string, float>();
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Podaj egzamin oraz ocene [np. podstawyProgramowania 4.5]: ");
                string[] egz = Console.ReadLine().Split(' ');
                egzaminy.Add(egz[0], float.Parse(egz[1]));
            }
            studenci.Add(new Student(kierunek, rokStudiow, egzaminy));
        }

        public void wyswietlStudentow()
        {
            int i = 1;
            foreach(Student s in studenci)
            {
                Console.WriteLine("-- Student {0} -- ", i);
                Console.WriteLine("Kierunek: " + s.NazwaKierunku);
                Console.WriteLine("Rok: " + s.RokStudiow);
                Console.WriteLine("Oceny egzaminów:");
                s.printExamGrades();
                i++;
            }
        }
    }
}
