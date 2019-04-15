using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_10_x_10
{
    class Name_10_x_10
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a name: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            int loop = 10;
            int i = 0;

            while(loop > 0)
            {
                while (i < 10)
                {
                    Console.Write(input + " ");
                    i += 1;
                }
                Console.WriteLine();

                i = 0;
                loop -= 1;
            }
            Console.ReadKey(true);
        }
    }
}
