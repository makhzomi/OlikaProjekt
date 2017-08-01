using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~ Welcome to my animal register ~~~~~~\n");
            Console.WriteLine("1) Add a dog.");
            Console.WriteLine("2) Add a cow.");
            Console.WriteLine("3) Add a cheep.");
            Console.WriteLine("4) Show all animals.");
            int i = int.Parse( Console.ReadLine());
            switch (i)
            {
                case 1: { Dog.AddDogs(); Console.ForegroundColor = ConsoleColor.DarkGray; break; }
                case 2: { Cow.AddCow(); Console.ForegroundColor = ConsoleColor.DarkGreen; break; }
                case 3: { Sheep.AddSheep(); Console.ForegroundColor = ConsoleColor.DarkMagenta; break; }
                case 4: { ReadAll(); break; }
                default: { Console.WriteLine("You need to make a choise!"); break; }
            }
            Console.ReadKey();
        }
        public static void ReadAll()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Mike\Desktop\KanDetVaraSantfilen.txt");          
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\nPress any key to exit.");
        }

        
    }
    
}
