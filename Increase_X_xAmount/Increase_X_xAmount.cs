using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increase_X_xAmount
{
    class Increase_X_xAmount
    {
        static void Main(string[] args)
        {
            Console.Write("How many lines do you want to have? ");
            int lines = int.Parse(Console.ReadLine());
            int loop = 0;
            int print = loop;

            while (loop <= lines)
            {
                print = loop;

                while (print > 0)
                {
                    Console.Write("x");
                    print = print - 1;
                }
                loop = loop + 1;
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}