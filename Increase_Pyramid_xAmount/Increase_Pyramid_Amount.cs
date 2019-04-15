using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increase_Pyramid_xAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            int InitialValue = 1;
            int print;
            int space;

            Console.Write("How many lines? ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int loop = 1 + ((input - 1) * 2);

            while (InitialValue <= loop)
            {
                print = 0;
                space  = input;

                while (space > InitialValue)
                {
                    Console.Write(" ");
                    space = space - 1;
                }

                while (print < InitialValue)
                {
                    Console.Write("x");
                    print = print + 1;
                }
                InitialValue = InitialValue + 2;
                input = input + 1;
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}