using System;
using System.Collections.Generic;

namespace Listor_och_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animal = new List<string>();

            while(animal.Count <= 4){
                Console.Clear();
                Console.WriteLine("Skriv namnet på ett djur.");
                string x = Console.ReadLine();

                animal.Add(x);
            }

            Console.Clear();
            Console.WriteLine("Djuren du skrev var: ");
            
            for(int i = 0; i < animal.Count; i++){
                Console.WriteLine(animal[i]);
            }
        }
    }
}
