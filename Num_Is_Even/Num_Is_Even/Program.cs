using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_Is_Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter the number:");
           int n = int.Parse(Console.ReadLine());
            int even;
            even = n% 2;
            if (even==0)
            {
                Console.WriteLine("Given Nubmer is Sum");
            }
            else
            {
                Console.WriteLine("Given Nubmer is Odd");
            }
            Console.ReadLine();
        }
    }
}
