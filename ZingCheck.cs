//ZingCheck

//A program that combines the functionality of ZconF and Dollars2Zingers
//still just as dumb as it sounds

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollars2zingers
{
    class zingcheck
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                userInput = DisplayMenu();
            } while (userInput != 3);
        }
        static public int DisplayMenu()
        {
                Console.Clear();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("1. Zingers to Dollars");
                Console.WriteLine("2. Dollars to Zingers");
                Console.WriteLine("3. Exit");
                string result = Console.ReadLine();

                switch (result)
                {
                    case "1":
                        zings2d();
                        break;
                    case "2":
                        d2zings();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                }
                
            }
        }
        static void zings2d()
        {
                //Total KFC Zinger cost per year
                const decimal ZING_COST = 5.95m;
                decimal output;             //output variable
                decimal zingerNumber;       //total number of zingers
                Console.Write("how many zingers?: ");
                zingerNumber = decimal.Parse(Console.ReadLine());
                output = zingerNumber * ZING_COST;
                Console.WriteLine("The total cost of the amount of zingers is " + output.ToString("C"));
                Console.ReadKey();
        }

        static void d2zings()
        {
            //initialize variables
            const decimal ZING_COST = 5.95m;        //Amount of KFC Zingers buyable with user defined money input
            decimal outputQ;        //output quotient variable

            decimal outputR;            //output remainder variable
            string qString;      //string of outputQ
            string rString;     //string of outputR
            string numString;        //string of number

            //decimal place checking, lifted from microsoft http://bit.ly/2uQuXgS
            decimal number = 0m;        //input number, with decimal place checking
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Please enter your Zinger budget in dollars");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out number))
                {
                    number = Math.Round(number, 2);     //rounds the number variable to 2 places
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please list your Zinger budget in numbers");

                }
            }
            //Actual interesting stuff begins here

            //Take budget, divides by ZING_COST for total number, and
            //calculates the remainder through modulus
            outputQ = number / ZING_COST;
            outputR = number % ZING_COST;

            //round down and convert outputQ to intQ
            outputQ = Decimal.Floor(outputQ);
            outputQ = Decimal.ToInt32(outputQ);

            //converts variables from decimal values to strings
            qString = outputQ.ToString();
            rString = outputR.ToString("C");
            numString = number.ToString("C");
            //Writes output to prompt
            Console.WriteLine("The amount of Zingers you can buy for {0} is {1} with {2} leftover", numString, qString, rString);
            Console.ReadKey();
        }

    }
}