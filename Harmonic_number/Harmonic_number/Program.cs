using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N;
            double Result = 0;

           
           Console.WriteLine("Calculate the harmonic series and their sum:\n");
           Console.WriteLine("Input the number of terms : ");
            N = Convert.ToInt32(Console.ReadLine());
           
            for (i = 1; i <= N; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                Result += 1 / (double)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1}", N, Result);
            Console.ReadLine();
        }
    }
}
