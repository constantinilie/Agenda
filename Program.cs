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
            Activitate act = new Activitate("Teme","scrie la mate", "Scoala",DateTime.Now);
            act.AfisareActivitate();
            Console.ReadKey();
        }
    }
    
}
