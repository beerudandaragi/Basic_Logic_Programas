using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the numebr:");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 400 == 0 || userInput % 4 == 0 && userInput % 100 != 0)
               
            {
                Console.WriteLine("Numbre is Leapyear");
            }
            else
            {
                Console.WriteLine("Numbre is  Not Leapyear");
            }
                Console.ReadLine();
        }
    }
}
