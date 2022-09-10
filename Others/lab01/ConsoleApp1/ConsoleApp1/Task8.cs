using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task8
    {
        class Pracownik {
            string imieNazwisko;
            Kontrakt kontrakt;

            public Pracownik(string imieN, string typKontraktu = "Staż", double stawkaMiesieczna = -1, double nadgodziny = 0)
            {
                imieNazwisko = imieN;
                kontrakt = new Kontrakt(typKontraktu, stawkaMiesieczna, nadgodziny);
            }

            public void changeContract(Kontrakt kontr)
            {
                kontrakt = kontr;
            }

            public override string ToString()
            {
                return imieNazwisko + " " + kontrakt.Pensja();
            }

            public class Kontrakt{
                string typKontraktu;
                double stawkaMiesieczna;
                double ileNadgodzin;
                public Kontrakt()
                {
                    typKontraktu = "Staż";
                    stawkaMiesieczna = 1000;
                    ileNadgodzin = 0;
                }

                public Kontrakt(string typKont, double stMiesieczna, double nadgodziny)
                {
                    typKontraktu = typKont;

                    if (stMiesieczna == -1)
                    {
                        if (typKontraktu == "Staż")
                        {
                            stawkaMiesieczna = 1000;
                            ileNadgodzin = 0;
                        }
                        else if (typKontraktu == "Etat")
                        {
                            stawkaMiesieczna = 5000;
                            ileNadgodzin = nadgodziny;
                        }
                    } else
                    {
                        stawkaMiesieczna = stMiesieczna;
                        ileNadgodzin = nadgodziny;
                    }
                }

                public double Pensja()
                {
                    if (typKontraktu == "Staż")
                    {
                        return stawkaMiesieczna;
                    } else if (typKontraktu == "Etat")
                    {
                        return stawkaMiesieczna + ileNadgodzin * (stawkaMiesieczna / 60);
                    } else
                    {
                        // if contract is unknown return negative value
                        return -1;
                    }
                }        
            }
        }

        public static void task8()
        {
            Pracownik p1 = new Pracownik("Intern Boo", "Staż");
            Pracownik p2 = new Pracownik("Jason Jay", "Etat", 150000, 23);
            Pracownik p3 = new Pracownik("Mayson May", "Etat", 130000, 41);
            Pracownik p4 = new Pracownik("Etathnic Tet", "Etat");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.ReadKey();
        }
    }
}
