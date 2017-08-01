using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalRegister

{
    public class Dog 
    {
        public string _dogName;
        public int _dogAge;
        public double _dogWight;
        public string _dogFood;

        public Dog(string dogName, int dogAge, double dogWight, string dogFood)
        {
            this._dogName = dogName;
            this._dogAge = dogAge;
            this._dogWight = dogWight;
            this._dogFood = dogFood;
        }
        public static void AddDogs()
        {

            List<Dog> dogs = new List<Dog>();

            Console.WriteLine("~~~~~~Dog~~~~~~");
            Console.WriteLine("Insert a dogs name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Insert a dogs age in years: ");
            int dogAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a dog wight in Kg: ");
            double dogWight = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert a dogs name of food: ");
            string dogFood = Console.ReadLine();

            Dog dog = new Dog(dogName, dogAge, dogWight, dogFood);
            dogs.Add(dog);

            StreamWriter infil = new StreamWriter(@"C:\SQL\filen.txt", true);
            infil.WriteLine("The dogs name is: {0}, The dogs age is: {1}, The dogs Wight is: {2}, The dogs food is: {3}", dogName, dogAge, dogWight, dogFood);
            infil.Close();
            Console.WriteLine("Registration complete!");

            Console.ReadKey();

        }
       
    }
}
