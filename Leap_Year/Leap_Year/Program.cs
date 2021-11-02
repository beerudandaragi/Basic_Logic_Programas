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
            int  Leapyear;
            Console.WriteLine("Enter the numebr:");
            int number = int.Parse(Console.ReadLine());
            Leapyear = number % 4;
            if (Leapyear == 0)
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
