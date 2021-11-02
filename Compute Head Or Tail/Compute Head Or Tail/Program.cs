using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Compute_Head_Or_Tail
{
    public class PercentageOfHeadAndTail
    {
        public void PrintHeadTail()
        {
            int head = 0;
            int tail = 0;

            Random rand = new Random();
            Console.WriteLine("Enter the total number of tosses: ");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                int key = rand.Next(0, 2);
                if (key == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }

            double resultHead = (head * 100) / userInput;
            double resultTail = (tail * 100) / userInput;

            Console.WriteLine("Head % is " + resultHead);
            Console.WriteLine("Tail % is " + resultTail);
        }       
                public static void Main(string[]args)
                {
                    Label: Console.WriteLine("1.print the percentage of coin flif");
                    Console.WriteLine("type the option");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("print the percentage of coin flif ");
                            PercentageOfHeadAndTail percentageofHeadandtail = new PercentageOfHeadAndTail();
                            percentageofHeadandtail.PrintHeadTail();
                            break;
                        default:
                            Console.WriteLine("invalid option");
                            break;
                    }
                    Console.WriteLine(" do you want continoue ....yes/no");
                     if (Console.ReadKey().KeyChar.ToString() == "yes")
                        {
                        goto Label;
                    }
                    Console.ReadKey();

                }
            }

            }

        
    

