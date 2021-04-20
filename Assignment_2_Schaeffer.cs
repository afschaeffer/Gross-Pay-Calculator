// Amy Schaeffer
// Program that calculates and displays gross pay based on user inputs.
using System;

namespace Schaeffer_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int hours;
            int rate;
            double gross_pay;


            while (++count <= 3)
            {
                Console.Write("Enter Hours Worked: ");
                hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Hourly Rate: ");
                rate = Convert.ToInt32(Console.ReadLine());

                if (hours <= 40)
                {
                    gross_pay = hours * rate;
                }
                else
                {
                    gross_pay = (rate * 40) + ((hours - 40) * (rate * 1.5));
                }

                Console.WriteLine($"Your Gross Pay: ${gross_pay}");
                Console.WriteLine();
            }
        }
    }
}

