using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 11;
            int num2 = 22;

            int plusresult = num1 + num2;
            int minusresult = num1 - num2;
            int multresult = num1 * num2;
            int quioresult = num1 / num2;
            int reminresult = num1 % num2;

            System.Console.WriteLine($"Plus result : {plusresult}");
            System.Console.WriteLine($"Plus result : {minusresult}");
            System.Console.WriteLine($"Plus result : {multresult}");
            System.Console.WriteLine($"Plus result : {quioresult}");
            System.Console.WriteLine($"Plus result : {reminresult}");

            int number10 = 213;
            int number11 = 313;
            number11 += number10;
            System.Console.WriteLine($"PP result : {number11}");
        }
    }
}
