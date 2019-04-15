using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrease_Pyramid
{
    class Decrease_Pyramid
    {
        static void Main(string[] args)
        {
            int loop = 11;
            int print = loop;
            int space = 0;
            int amount = space;

            while (loop > 0)
            {
                print = loop;
                amount = space;

                while (amount > 0)
                {
                    Console.Write(" ");
                    amount = amount - 1;
                }


                while (print > 0)
                {
                    Console.Write("x");
                    print = print - 1;
                }

                loop = loop - 2;
                space = space + 1;
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}