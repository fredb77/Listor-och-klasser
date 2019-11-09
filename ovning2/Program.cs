using System;
using System.Collections.Generic;

namespace ovning2
{
    class Lion
    {
        String name;
        String age;
        String sound;

        public Lion(String name, String age, String sound)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
        }

        public string Talk()
        {
            return (name + " är ett lejon som är " + age + " år gammal. " + sound);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Lion simba = new Lion ("Simba", "15", "Vvroaaaaooo!\n");
            Lion astro = new Lion ("Astro", "2", "Vvroaaaaooo!\n");
            Console.WriteLine(simba.Talk() + astro.Talk());
        }
    }
}
