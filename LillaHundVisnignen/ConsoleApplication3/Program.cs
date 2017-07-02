using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool visaMeny = true;
            while (visaMeny)
            {
                visaMeny = HuvudMeny();
            }
        }

        public static bool HuvudMeny()
        {
            Console.Clear();
            Console.WriteLine("--{Välkommen till hundvisningen--}\n");
            Console.WriteLine("Välj ett alternativ: \n");
            Console.WriteLine("1) Skriv ut hundar");
            Console.WriteLine("2) Exit");
            string resultatet = Console.ReadLine();
            if (resultatet == "1")
            {
                VisaHundar();
                return true;
            }
            else if (resultatet == "2")
            {
                return false;
            }
            return true;
        }
        public static void VisaHundar()
        {
            Dog myDog1 = new Dog()
            {
                Ras = "Pitbull",
                Ålder = 5,
                Ort = "Borås"
            };
            Dog myDog2 = new Dog()
            {
                Ras = "Amstaff",
                Ålder = 3,
                Ort = "Göteborg"
            };

            Dog myDog3 = new Dog()
            {
                Ras = "Hokaido",
                Ålder = 1,
                Ort = "Stockholm"
            };

            List<Dog> myDogs = new List<Dog>(2);
            myDogs.Add(myDog1);
            myDogs.Add(myDog2);
            myDogs.Add(myDog3);

            foreach (Dog c in myDogs)
            {
                Console.WriteLine("Ras = {0}, Ålder = {1}, Ort = {2}", c.Ras, c.Ålder, c.Ort);
            }
            Console.ReadLine();

        }

        public class Dog
        {
            public string Ras { get; set; }
            public int Ålder { get; set; }
            public string Ort { get; set; }
        }
    }
}
