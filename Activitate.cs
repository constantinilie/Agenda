using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Activitate   // Am creeat clasa- TEMA LAB 2
    {
        public string Nume { get; set; } // Numele activitatii
        public string Descriere { get; set; } // Descrierea activitatii
        public string Tip { get; set; } // Tipul activitatii (ex: Scoala, munca, recreere)
        public DateTime DataOra { get; set; } // data si ora


        public Activitate(string nume, string descriere, string tip, DateTime dataOra)
        {
            Nume = nume;
            Descriere = descriere;
            Tip = tip;
            DataOra = dataOra;
        }

        public void AfisareActivitate()
        {
            Console.WriteLine($"Nume:\t{Nume}");
            Console.WriteLine($"Descriere:{Descriere}");
            Console.WriteLine($"Data si ora :{DataOra}");
            Console.WriteLine($"Tipul:\t{Tip}");
        }

        
    }
}
