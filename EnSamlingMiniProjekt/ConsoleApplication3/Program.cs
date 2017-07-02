using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnSamlingMiniProjekt

{
    class Program
    {
        static void Main(string[] args)
        {



            /*
            ////kommunicerar med användaren och kopierar över det som skrivs. 
            Console.WriteLine("Vänligen skriv in fullständiga namn: ");
            string inMatningNamn = Console.ReadLine();
            Console.WriteLine("Vänligen mata in födelsedatum(årtalet): ");
            string inMatningDatum = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Du heter " + inMatningNamn + "" + "" + " och du är född år: " + inMatningDatum);
            Console.ReadLine();
            */



            //Console.WriteLine("Mike är väldigt generös av sig :)");
            //Console.Write("Välj en dörr och se vad som döljer sig bakom, 1, 2 eller dörr 3: ");
            //string kundVärde = Console.ReadLine();
            //string meddelande = "";

            //if (kundVärde == "1")
            //    meddelande = "Du vann en ny bil!";
            //else if (kundVärde == "2")
            //    meddelande = "Du vann en ny båt!";
            //else if (kundVärde == "3")
            //    meddelande = "Du vann inte ett skit!!";
            //else
            //{
            //    meddelande = "Sry, fattar inte vad du skrev där..:(";
            //    meddelande += "du förlorade buddy";
            //}
            //Console.WriteLine(meddelande);
            //Console.ReadLine();


            /*
            //ett annat sätt att lösa detta på men testar endast på dörr nr1
             
            Console.WriteLine("Mike är väldigt generös av sig :)");
            Console.Write("Välj en dörr och se vad som döljer sig bakom, 1, 2 eller dörr 3: ");
            string kundVärde = Console.ReadLine();
            string meddelande1 = (kundVärde == "1") ? "båt" : "Grattis!";
            Console.WriteLine("Du valde dörr {0}, och du vann en {1}.", kundVärde, meddelande1);
            Console.ReadKey();
            */


            /////en forloop som letar fram nr 8 i en lista av 11 nr

            //for (int i = 1; i < 11; i++)
            //{
            //    if (i == 15)
            //    {
            //        Console.WriteLine("found 8");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Vald nummer finns inte i listan!");
            //        break;
            //    }
            //}
            //Console.ReadKey();


            /*
            ////en array som ska skriva ut nr 16
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 12;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[3]);
            Console.ReadLine();
            */




            /*
            ////räknar ut hur många bokstäver det finns i vald box
            string[] namn = new string[5];

            namn[0] = "hasse";
            namn[1] = "Mike";
            namn[2] = "Jonas";
            namn[3] = "Omin";
            namn[4] = "Sara";

            //Console.WriteLine(namn[3] + " " + namn[2]); //skriver ut de namn som finns i boxen alltså(omin och Jonas)
            Console.WriteLine(namn.Length);
            Console.ReadLine();
            */




            /*
            /////listar upp alla namn som finns i arrayn
            string[] namn = new string[] { "Mike", "Jonas", "Dinh", "Thinh", "Michael" };

            foreach (string name in namn)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */




            /*
           /// reverse array -kör meddelandet som finns i Zig fast bakvänt
            string Zig = "Detta kan ändå vara bra att kunna i framtiden kanske?" +
                " eller inte, vem vet ;)";

            char[] charArray = Zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
            */




            /////olika stringformat------


            // string myString = "My \"so-called\" life";
            //string myString = "what if i need a \nnew line?";

            //string myString = "go to you c:\\ drive";
            //string myString = @"go to your c:\ drive";

            //string myString = string.Format("{0} = {1}", "First", "Sekond");

            //string myString = string.Format("{0:C}", 123.45);//C: representerar valutan

            //string myString = string.Format("{0:N}", 1234567890);//:N skapar mellanrum mellan stora nummer
            //string myString = string.Format("Procent: {0:P}", .123);//:P omvanldar till procent tal
            //string myString = string.Format("Tel nummer: {0:(###) ###-####}", 1234567890);//# används för nummer eller liknande

            /*
            string myString = " I do never have to go where you don't follow  ";
            //myString = myString.Substring(6, 14);//väljer ut de ord som hamnar under dessa nr
            //myString = myString.Replace(" ", "--");//byter ut alla mellanslag mot --
            //myString = myString.Remove(6, 14);

            myString = string.Format("Längd före: {0} -- Längd efter: {1}", 
                myString.Length, myString.Trim().Length);//här beräknas hur många bokstäver det fanns med mellanslag, och efter mellanslagen raderats.
                */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */


            /*
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
            */




            //////Formatera date-----date and time-----

            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString()); //visar både datum och tid i nuläget
            //Console.WriteLine(myValue.ToShortDateString()); //visar endast datum i nuläget
            //Console.WriteLine(myValue.ToShortTimeString()); //visar endast tid i nuläget
            //Console.WriteLine(myValue.ToLongDateString()); //visar den långa versionen av datum
            //Console.WriteLine(myValue.ToLongTimeString());  // visar lång vesrion av tide i nuläget
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());


            


        }
    }
}
