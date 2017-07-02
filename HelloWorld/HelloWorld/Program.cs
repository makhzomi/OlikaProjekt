using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt förnamn: ");
           // string förNamn;
            String förNamn = Console.ReadLine();
            Console.Clear();
            
            Console.Write("Skriv ner ditt efternamn: ");
           String efterNamn = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Du heter: " + förNamn + " " + efterNamn);
            Console.Write("Nu kan vi gå vidare till din ålder! ;)\n");
           
            Console.Write("Hur gammal är du?");
            int ålder;
            ålder = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Du är " + ålder + " " + "år gammal!\nDet var la bra att veta :)))))");

            Console.ReadLine();


        }
    }
}
