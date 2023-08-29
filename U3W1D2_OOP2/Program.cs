using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3W1D2_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Michele", "Iacobi", 35) { };
            Prodotto prodotto1 = new Prodotto() { };

            persona1.GetDettagli();
            prodotto1.CalcolaTotale();
            Console.ReadLine();
        }

    }

   
}

