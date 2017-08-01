using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year_of_zingers
{
    class Program
    {
        static void Main()
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
    }
}