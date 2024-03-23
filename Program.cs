using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            AdministrareActivitati adminActivitati= new AdministrareActivitati();
            Activitate activitateNoua = new Activitate();
            int nrActivitati = 0;
            string optiune;
            do
            {
                Console.WriteLine("C. Citire informatii activitate de la tastatura");
                Console.WriteLine("I.Afisarea informatiilor despre ultima activitate introdusa");
                Console.WriteLine("A.Afisare activitati din fisier");
                Console.WriteLine("S.Salvare activitate in vector de obiecte");
                Console.WriteLine("K.Cauta o activitate dupa tip");
                Console.WriteLine("N.Cauta o activitate dupa nume");
                Console.WriteLine("X.Inchidere program");
                Console.WriteLine("Alegeti o optiune:");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "C":
                        activitateNoua = CitireActivitateTastatura();
                        break;
                    case "I":
                        AfisareActivitate(activitateNoua);
                        break;
                    case "S":
                        adminActivitati.AdaugaActivitate(activitateNoua);
                        nrActivitati++;
                        break;
                    case "A":
                        Activitate[] activitati = adminActivitati.GetActivitati(out nrActivitati);
                        AfisareActivitati(activitati, nrActivitati);
                        break;
                    case "K":
                        Console.Write("Introduceti tipul activitatii dorite: ");
                        string tipCautat=Console.ReadLine();
                        Activitate[] activitatiGasite_Tip = adminActivitati.CautaDupaTip(tipCautat);
                        AfisareActivitati(activitatiGasite_Tip, activitatiGasite_Tip.Length);
                        break;
                    case "N":
                        Console.Write("Introduceti numele activitatii dorite: ");
                        string numeCautat = Console.ReadLine();
                        Activitate[] activitatiGasite_Nume = adminActivitati.CautaDupaNume(numeCautat);
                        AfisareActivitati(activitatiGasite_Nume, activitatiGasite_Nume.Length);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");
        }
        


        public static Activitate CitireActivitateTastatura() // Tema LAB3 - Citire date tastatura
        {
            DateTime dateTime;
            bool k = false;
            Console.Write("Introduceti numele activitatii:");
            string nume = Console.ReadLine();
            Console.Write("Introduceti descrierea activitatii:");
            string descriere= Console.ReadLine();
            Console.Write("Introduceti tipul activitatii:");
            string tip= Console.ReadLine();
            do {
                Console.WriteLine("Introduceti data si ora ( zz-ll-aaaa hh:mm:ss):");
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out dateTime))
                    {
                    k = true;

                } else
                {
                    Console.WriteLine("Formatul este incorect, reintroduceti!");
                }
            } while (!k);
                
            Activitate activitate = new Activitate( nume, descriere, tip,dateTime);
            return activitate;
            
        }

        public static void AfisareActivitate(Activitate activitate)
        {
            string infoActivitate = string.Format($"Ultima activitate introdusa:\nNume:{activitate.Nume}\nDescriere:{activitate.Descriere}\n" +
                $"Tip:{activitate.Tip}\nData si ora:{activitate.DataOra}\n");
            Console.WriteLine(infoActivitate);
        } 
        public static void AfisareActivitati(Activitate[] activitati, int nrActivitati ) //TEMA LAB 3- Afisare datelor din vector
        {
            Console.WriteLine("Activitatile sunt:");
            for (int contor=0; contor<nrActivitati; contor++)
            {
                string infoActivitate = activitati[contor].InfoActivitate();
                Console.WriteLine(infoActivitate);
            }
        } 
    }
    
}
