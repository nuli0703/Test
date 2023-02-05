using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //반복문
            int numberlimit = 10;
            while(numberlimit > 0)
            {
                System.Console.WriteLine("Hi");

                numberlimit--;
            }

            //작동 후, 반복체크
            do
            {
                System.Console.WriteLine("Hi");

            } while (numberlimit > 5);


        }
    }
}
