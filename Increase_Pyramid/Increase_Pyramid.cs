using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increase_Pyramid
{
    class Increase_Pyramid
    {
        static void Main(string[] args)
        {
            int loop = 1;
            int print = loop;
            int space = 6;
            int amount = space;

            while (loop <= 11)
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

                loop = loop + 2;
                space = space - 1;
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}