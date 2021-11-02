using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_Quotient_and_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int  Dividend = 21, Divisor =5, Quotient, Remainder;

            Remainder = Dividend  %  Divisor ;
            Console.WriteLine("Remainder is:  " + Remainder);

            Quotient = Dividend  /  Divisor ;
            Console.WriteLine("Quotient is:  " + Quotient);

            Console.ReadLine();

        }
            

        }
    }

