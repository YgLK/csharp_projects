using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task9
    {
        class Ssak {
            double waga = 0;
            
            public Ssak(double w)
            {
                waga = w;
            }
            
            public virtual double SprawdzWage() {
                return waga;
            }

            public virtual double PijWode()
            {
                return 0;
            }
            public virtual double JemSiano()
            {
                return 0;
            }
        }

        class Krowa : Ssak
        {
            public Krowa(double waga) : base(waga){}

            public override double JemSiano()
            {
                return 80;
            }
            public override double PijWode()
            {
                return 3;
            }

        }

        class Owca : Ssak
        {
            public Owca(double waga) : base(waga) { }

            public override double JemSiano()
            {
                return 40;
            }
            public override double PijWode()
            {
                return 2;
            }
        }
        class Kotek : Ssak
        {
            public Kotek(double waga) : base(waga) { }

            public override double PijWode()
            {
                return 0.5;
            }

            public void JemWszystkoOproczSiana()
            {}
        }

        class Farma
        {
            ArrayList zwierzeta;
            int fixedSize = 5;
            public Farma()
            {
                zwierzeta = new ArrayList();
            }

            public void dodajZwierze(Ssak s)
            {
                if (zwierzeta.Count <= fixedSize)
                {
                zwierzeta.Add(s);
                } else
                {
                    Console.WriteLine("Farma jest pełna!");
                }
            }

            public double IleWodyWypitej()
            {
                double ileWody = 0;
                foreach (Ssak s in zwierzeta)
                {
                    ileWody += s.PijWode();
                }
                return ileWody;
            }

            public double IleSianaZjedzonego()
            {
                double ileSiana = 0;
                foreach (Ssak s in zwierzeta)
                {
                    ileSiana += s.JemSiano();
                }
                return ileSiana;
            }

            public double NajlzejszeZwierze()
            {
                double minWeight = Double.PositiveInfinity;
                foreach (Ssak s in zwierzeta)
                {
                    if(minWeight > s.SprawdzWage()){
                        minWeight = s.SprawdzWage();
                    }
                }
                return minWeight;
            }
        }

        public static void task9()
        {
            Ssak z1 = new Owca(29);
            Krowa z2 = new Krowa(32);
            Kotek z3 = new Kotek(3.49);
            Krowa z4 = new Krowa(32);
            Kotek z5 = new Kotek(3.49);
            Kotek z6 = new Kotek(3.49);

            Farma f = new Farma();
            f.dodajZwierze(z1);
            f.dodajZwierze(z2);
            f.dodajZwierze(z3); 
            f.dodajZwierze(z4);
            f.dodajZwierze(z5);
            f.dodajZwierze(z3);
            // Farm has capacity of 5 mammals so next animals can't be added to the list
            f.dodajZwierze(z4);
            f.dodajZwierze(z5);

            Console.WriteLine("Ilość zjedzonego siana: " + f.IleSianaZjedzonego());
            Console.WriteLine("Ilość wypitej wody: " + f.IleWodyWypitej());
            Console.WriteLine("Waga najlżejszego zwierzęcia: " + f.NajlzejszeZwierze());
            Console.ReadKey();

        }
    }
}
