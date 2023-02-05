using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Switch(비교대상)
            int number = 3;
            switch(number)
            {
                case 0:
                    System.Console.WriteLine("0");
                    break;
                case 1:
                    System.Console.WriteLine("1");
                    break;
                case 2:
                    System.Console.WriteLine("2");
                    break;
                case 3:
                    System.Console.WriteLine("3");
                    break;
                default:
                    break;

            }

            for(int i = 0 i < 5; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("0");
                    continue;

                }
                else if (i == 1)
                {
                    Console.WriteLine("1");
                    Console.WriteLine("11");
                    continue;
                    Console.WriteLine("111");
                }
                else if (i == 2)
                {
                    Console.WriteLine("2");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("3");
                }
            }
            Console.WriteLine("끝");



        }

    }
}
