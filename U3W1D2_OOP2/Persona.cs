using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace U3W1D2_OOP2
{
    internal class Persona
    {
        //Proprietà
        public string Nome { get; set; }
        public string Cognome { get; set;}
        public int Età { get; set; }

        //Metodi
        public void GetName(){
             Console.WriteLine("Scrivi il tuo nome:");
            Nome = Console.ReadLine();
   
        }

        public void GetSurname()
        {
            Console.WriteLine("Scrivi il tuo cognome:");
            Cognome = Console.ReadLine();
        }

        public void GetEta()
        {
            Console.WriteLine("Scrivi la tua età:");
            Età = int.Parse(Console.ReadLine());
        }

        public void GetDettagli()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Età: {Età}");

        }

        public Persona() { }
        public Persona(string nome, string cognome, int età) {
            Nome = nome;
            Cognome = cognome;
            Età = età;
        }
    }
}

