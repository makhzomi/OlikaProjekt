using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GångerTabellen
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int result;

            Console.Write("Enter a number to show a multiplication table (1-10): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYou chosed number: {0}", x);
            result = x * 1;
            Console.WriteLine("\nThe table is: {0} x {1} = {2}", x, 1, result, Console.ForegroundColor = ConsoleColor.Yellow);
            result = x * 2;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 2, result, Console.ForegroundColor = ConsoleColor.Red);
            result = x * 3;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 3, result, Console.ForegroundColor = ConsoleColor.White);
            result = x * 4;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 4, result, Console.ForegroundColor = ConsoleColor.Gray);
            result = x * 5;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 5, result, Console.ForegroundColor = ConsoleColor.Green);
            result = x * 6;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 6, result, Console.ForegroundColor = ConsoleColor.Magenta);
            result = x * 7;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 7, result, Console.ForegroundColor = ConsoleColor.DarkCyan);
            result = x * 8;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 8, result, Console.ForegroundColor = ConsoleColor.DarkRed);
            result = x * 9;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 9, result, Console.ForegroundColor = ConsoleColor.DarkYellow);
            result = x * 10;
            Console.WriteLine("The table is: {0} x {1} = {2}", x, 10, result, Console.ForegroundColor = ConsoleColor.DarkGreen);

            Console.ReadLine();
            
                


        }
    }
}
