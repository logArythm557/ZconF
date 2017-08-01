//Dollars2Zingers.cs

//A program that tells you how many Zingers
//you can buy in adelaide with the amount of money you have.
//it's just as dumb as it sounds

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollars2zingers
{
    class d2z
    {
        static void Main()
		{
			//Amount of KFC Zingers buyable with user defined money input
			const decimal ZING_COST = 5.95m;
			decimal outputQ;		//output quotient variable
			decimal outputR;			//output remainder variable
			//decimal place checking, lifted from microsoft http://bit.ly/2uQuXgS
			decimal number = 0m;		//input number, with decimal place checking
			bool valid = false;
			while(!valid)
			{
				Console.WriteLine("Please enter your Zinger budget in dollars");
				string input = Console.ReadLine();
				if(decimal.TryParse(input, out number))
				{
					number = Math.Round(number, 2);		//rounds the number variable to 2 places
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
			 
            //need to round the number of zingers too

			//Writes output to prompt
			Console.WriteLine("The amount of Zingers you can buy for $" + number.ToString("C") + " is " + outputQ.ToString("C") + " with " + outputR.ToString("C") + " leftover");
		}
	}
}
