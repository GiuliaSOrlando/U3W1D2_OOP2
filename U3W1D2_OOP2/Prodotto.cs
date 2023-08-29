using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U3W1D2_OOP2
{
    internal class Prodotto
    {
        //Proprietà
        public string NomeProdotto { get; set; }
        public int Prezzo { get; set; }

        public int Quantità { get; set; }

        //Metodi
        public void CalcolaTotale()
        {
            Console.WriteLine("Inserire il nome del prodotto:");
            NomeProdotto = Console.ReadLine();
            Console.WriteLine("Quante unità di questo prodotto stai acquistando:");
            Quantità = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanl è il prezzo del prodotto:");
            Prezzo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Il prezzo totale per {NomeProdotto} è di {Quantità * Prezzo} €");


        }

        public Prodotto() {

        }


    }
    }
