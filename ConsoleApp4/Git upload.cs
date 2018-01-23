using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    { //This is my second commit to GIT HUB
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            int z = x;

            if (y == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; i < y; i++)
                {
                    z *= x;
                }
                Console.WriteLine(z);
            }
        }    
    }
}
