using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrease_X_xAmount
{
    class Decrease_X_xAmount
    {
        static void Main(string[] args)
        {
            Console.Write("How many 'X's do you want to start with: ");
            int loop = int.Parse(Console.ReadLine());
            int print = loop;
            Console.WriteLine();

            while (loop > 0)
            {
                print = loop;

                while (print > 0)
                {
                    Console.Write("x");
                    print = print - 1;
                }
                loop = loop - 1;
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}