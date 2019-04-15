using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names_Amount_x_Amount
{
    class Names_Amount_x_Amount
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a name: ");
            string input = Console.ReadLine();

            Console.Write("What width + height: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int loop = length;
            int i = 0;

            while (loop > 0)
            {
                while (i < length)
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