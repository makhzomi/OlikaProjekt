using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalRegister
{
    public class Sheep 
    {
        public string _sheepName;
        public int _sheepAge;
        public double _sheepWight;
        public double _sheepKiloWool;
        public string _sheepWoolColor;

        public Sheep(string sheepName, int sheepAge, double sheepWight, double sheepKiloWool, string sheepWoolColor)
        {
            this._sheepName = sheepName;
            this._sheepAge = sheepAge;
            this._sheepWight = sheepWight;
            this._sheepKiloWool = sheepKiloWool;
            this._sheepWoolColor = sheepWoolColor;

        }
        public static void AddSheep()
        {
            
            List<Sheep> sheeps = new List<Sheep>();
            Console.WriteLine("~~~~~~Sheep~~~~~~");
            Console.WriteLine("Insert a sheeps name: ");
            string sheepName = Console.ReadLine();
            Console.WriteLine("Insert a sheeps age in years: ");
            int sheepAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a sheeps wight in Kg: ");
            double sheepWight = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert a sheeps wool wight in kg: ");
            double sheepKiloWool = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert the wools color: ");
            string sheepWoolColor = Console.ReadLine();

            StreamWriter infil = new StreamWriter(@"C:\SQL\filen.txt", true);
            infil.WriteLine("The sheeps name is: {0}, The sheeps age is: {1}, The sheeps wight is: {2}, The sheeps wool in kg is: {3}kg, The sheeps wool color is: {4}", sheepName, sheepAge, sheepWight, sheepKiloWool, sheepWoolColor);
            infil.Close();
            Console.WriteLine("Registration complete!");
        }
    }
}
