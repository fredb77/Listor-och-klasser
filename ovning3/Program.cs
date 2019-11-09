
/*
Skriva ett konsolprogram som ställer en rad olika frågor till användaren om en viss person...
Vad heter personen? För- och efternamn. (spara dessa separat)
Vilken ålder har personen?
Vart i världen bor personen?
Vilken sysselsättning har personen?
När alla frågor har svarats på ska informationen sparas i ett objekt av en lämplig klass som du skapat.
Programmet ska sen rensa konsolen och presentera informationen man matat in på ett snyggt sätt.
*/

using System;

namespace ovning3
{
    class Person
    {
        String fname;
        String lname;
        String age;
        String place;
        String doing;

        public Person(String fname, String age, String place, String doing, String lname)
        {
            this.fname = fname;
            this.age = age;
            this.place = place;
            this.doing = doing;
            this.lname = lname;
        }

        public string hen()
        {
            return (fname + " är " + age + " år och bor i " + place + ". Hen är " + doing + " och heter " + lname + " i efternamn.");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vad heter du i förnamn?");
            String fname = Console.ReadLine();

            Console.WriteLine("Vad heter du i efternamn?");
            String lname = Console.ReadLine();

            Console.WriteLine("Vart bor du?");
            String place = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            String age = Console.ReadLine();

            Console.WriteLine("Vad har du för sysselsättning?");
            String doing = Console.ReadLine();

            Person vem = new Person (fname, age, place, doing, lname);

            Console.Clear();
            Console.WriteLine("\n-----------------------------------------------------------------------------------\n");
            Console.WriteLine(vem.hen());
            Console.WriteLine("\n-----------------------------------------------------------------------------------");
        }
    }
}
