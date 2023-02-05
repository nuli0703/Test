using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3 + 2;
            

            if (number < 0)
            {
                System.Console.WriteLine("0보다 작습니다");
            }
            else if (number < 2)
            {
                System.Console.WriteLine("0보다 크고 2보다 작다");
            }
            else if (number < 3)
            {
                System.Console.WriteLine("2보다 크고 3보다 작다");
            }
            else
            {
                System.Console.WriteLine("4보다 크다");
            }




            string number1;
            string number2;

            int number3;
            int number4;


            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            number1 = System.Console.ReadLine();
            number3 = Convert.ToInt32(number1);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            number2 = System.Console.ReadLine();
            number4 = Convert.ToInt32(number2);

            int plusResult = number3 + number4;

            if (plusResult < 0)
            {
                System.Console.WriteLine("0보다 작습니다");
            }
            else if (plusResult < 10)
            {
                System.Console.WriteLine("0보다 크고 10보다 작다");
            }
            else if (plusResult < 20)
            {
                System.Console.WriteLine("10보다 크고 20보다 작다");
            }
            else if (plusResult < 30)
            {
                System.Console.WriteLine("20보다 크고 30보다 작다");
            }
            else if (plusResult < 40)
            {
                System.Console.WriteLine("30보다 크고 40보다 작다");
            }
            else if (plusResult < 50)
            {
                System.Console.WriteLine("40보다 크고 50보다 작다");
            }

            else
            {
                System.Console.WriteLine("50보다 크다");
            }



        }
    }
}
