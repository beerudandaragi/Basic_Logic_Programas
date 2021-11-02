using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Two_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=5,B=6;
            Console.WriteLine("Before swap two number A={0} And B={1}  ", A, B);
            A = A * B;
            B= A / B;
            A = A / B;
            Console.WriteLine("After swap two number  A={0} And B={1} " ,A, B);
            Console.ReadLine();

        }
    }
}
