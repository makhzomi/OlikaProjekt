using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NågotKonstigt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool VisaMeny = true;
            while (VisaMeny)
            {
                VisaMeny = GissaIgen();
            }
        }
        
        private static void Gissa()
        {

            Random r = new Random();

            int randomYear = r.Next(2017, 2020); // random år mellan 2017-2020   
            int randomMonthNr = r.Next(1, 13);  //random månad mellan 1-12
            int maxDayNr = DateTime.DaysInMonth(randomYear, randomMonthNr);  //antal maxdagar i en månad
            int randomDayNr = r.Next(1, (maxDayNr + 1)); //random dagar i månaden 
            Console.WriteLine("--{När kommer du få ett jobb-spelet}--\n");
            Console.WriteLine("du kommer att få ett jobb:" + randomYear + "-" + randomMonthNr + "-" + randomDayNr);
            Console.ReadLine();
        }

        private static bool GissaIgen()
        {
            Gissa();
            Console.Clear();
            Console.WriteLine("Är du nöjd med svaret? \nJa \nNej");
            string inMatning = Console.ReadLine();
            if (inMatning == "Ja")
            {
                Console.WriteLine("Dåså, vi ser fram emot detta!");
                Console.Clear();
                return true;
            }

            else if (inMatning == "Nej")
            {
                Console.Clear();
                Console.WriteLine("Då gissar vi igen!");
                Gissa();
                return true;
            }
            return false;
        }

    }
}
