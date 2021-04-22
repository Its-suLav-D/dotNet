using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sulav Dahal";
            string location = "Kathmandu, Nepal";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            var currentDate = DateTime.Now;

            var nextChristmas = new DateTime(currentDate.Year,12,25);
            var christmas = nextChristmas - currentDate;
            var remDays = Math.Round(christmas.TotalDays);

            Console.WriteLine($"Hey {name},  There is still {remDays} days remaining until next Christmas");

            Console.WriteLine("-----------------------------------------------------------");

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please enter the Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine($"The length of the wood is { woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");
            Console.WriteLine("Thank you !! Have a great day!!. Press any key to exit");

            Console.ReadKey();
        }
    }
}
