using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite Number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "Have an awesome Favorite number." : "Youd do not havr an awesome favorite number.";

            //Console.WriteLine(result);
            //Console.ReadLine();

            int packageWeight = 30;
            int maxWeight = 50;

            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below (Enter name to Proceed).");
            String name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", How much does  the package weight?");
            int currentWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the Package width:");
            Console.ReadLine();

            Console.WriteLine("Please enter the Package height:");
            Console.ReadLine();

            Console.WriteLine("Please enter the Package length:");
            Console.ReadLine();

            if (packageWeight > maxWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
            }
            else if (packageWeight < maxWeight)
            {
                Console.WriteLine("Package can be shipped.");
            }
            

            Console.ReadLine();

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is not room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();
        }
    }
}
