using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AnimalRegister;

namespace AnimalRegister
{
    public class Cow
    {
        public string _cowName;
        public int _cowAge;
        public double _cowWight;
        public double _cowLiterMilk;
        public double _cowCreamProcent;

        public Cow(string cowName, int cowAge, double cowWight, double CowLiterMilk, double cowCreamProcent)
        {
            this._cowName = cowName;
            this._cowAge = cowAge;
            this._cowWight = cowWight;
            this._cowLiterMilk = CowLiterMilk;
            this._cowCreamProcent = cowCreamProcent;
        }
        public static void AddCow()
        {
            List<Cow> cows = new List<Cow>();
            Console.WriteLine("~~~~~~Cow~~~~~~");
            Console.WriteLine("Insert a cows name: ");
            string cowName = Console.ReadLine();
            Console.WriteLine("Insert a cows age in years: ");
            int cowAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a cows wight in Kg: ");
            double cowWight = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert how many liter a cow produce milk in a day: ");
            double CowLiterMilk = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert a cows cream in Procent: ex: 0,03 means 3%");
            double cowCreamProcent = double.Parse(Console.ReadLine());

            StreamWriter utfil = new StreamWriter(@"C:\SQL\filen.txt", true);
            utfil.WriteLine("The cows name is: {0}, The cows age is: {1}, The cows wight is: {2}kg, The cows produce {3}L milk, The cows milk contain {4:P}", cowName, cowAge, cowWight, CowLiterMilk, cowCreamProcent);
            utfil.Close();
            Console.WriteLine("Registration complete!");
        }
    }
}
