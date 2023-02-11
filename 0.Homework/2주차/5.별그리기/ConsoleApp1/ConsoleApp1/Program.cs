using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <6; a++)
            {
                int b = 0;
                while(b<a)
                {
                    Console.Write("오");
                    b++;
                }
                System.Console.WriteLine();

            }
            System.Console.WriteLine();
            for (int a = 5; a > 0; a--)
            {
                int b = 0;
                while (b < a)
                {
                    System.Console.Write("아");
                    b++;
                }
                System.Console.WriteLine();

            }


        }

    }
}
