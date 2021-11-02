using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet_is_Vowel_or_Consonant
{
    class Program
    {
       static void VowelOrConsonant(char x)
        {
            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            Console.ReadLine();
        }
        
       static void Main(string[] args)
        {
            
            VowelOrConsonant('B');
        }
        
        
    }
}
