using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEnums
{
    enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    class Program
    {
        

        static void Main(string[] args)
        {

            // Months of the Year.
            // Using the DaysOfWeek enumeration as an example, create an enumeration to represent the months of the year.  Assign them the values 1 through 12.  
            // Write a program to ask the user for a number between 1 and 12.  
            // Check to ber usure that they gave you a value in the right range and use an explicit cast to convert the number to your month enumeration.  
            // Then, using a switch statement or if statement to print out the full name of the month they entered.

            Console.WriteLine("Enter a number 1-12, and I will give you the enumeration for the month");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input > 0 && input < 13)
            {
                Month month = (Month) input;
                Console.WriteLine(month);
            }

            else
            {
                Console.WriteLine("That number was too high or too low.");
            }

        }
    }
}
