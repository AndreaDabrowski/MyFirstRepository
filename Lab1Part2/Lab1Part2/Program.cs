using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a start date for calculation in the MM/DD/YYYY format: ");
            //Converts the first user input into the DateTime data type.
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter an end date for calculation in the MM/DD/YYYY format: ");
            //Converts second user input.
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            //Calculation variable subtracts the start date from the end date.
            TimeSpan Calculation = endDate.Subtract(startDate);
            //Displays the difference in hours, minutes, seconds.
            Console.WriteLine("The difference between the two dates in hours is {0}, The difference in minutes is {1}, and the difference in seconds is {2}.", Calculation.TotalHours, Calculation.TotalMinutes, Calculation.TotalSeconds);
            Console.ReadLine();
        }
    }
}
