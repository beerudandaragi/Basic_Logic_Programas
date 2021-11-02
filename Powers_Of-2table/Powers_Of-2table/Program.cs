using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_Of_2table
{ 
    class Program
    {
        static void Main(string[] args)
        {
            double i, N=2, result;
            //Console.WriteLine("Enter the number:");
            //N = Double.Parse(Console.ReadLine());
            for (i = 1; i<31; i++)
            {
                result = i;


                Console.WriteLine("power of {0}^{1}={2}", N, result, Math.Pow(N, result));

            }
            Console.ReadLine();
        }

            
        }

        }

    

