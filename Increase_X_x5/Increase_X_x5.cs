using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increase_X_x5
{
    class Increase_X_x5
    {
        static void Main(string[] args)
        {
            int loop = 0;
            int print = loop;

            while (loop <= 5)
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