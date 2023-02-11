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
            string number1;
            string number2;

            int connumber1;
            int connumber2;

            

            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            number1 = System.Console.ReadLine();
            connumber1 = Convert.ToInt32(number1);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            number2 = System.Console.ReadLine();
            connumber2 = Convert.ToInt32(number2);

            int plusResult = connumber1 + connumber2;
            int singlenumber = connumber1 % 2;
            int singlenumber2 = connumber2 % 2;

            //if문
            if (plusResult <= 10)
            {
                System.Console.WriteLine("10 이하입니다.");
            }
            else if (plusResult <= 20)
            {
                System.Console.WriteLine("20 이하입니다.");
            }
            else if (plusResult <= 30)
            {
                System.Console.WriteLine("30 이하입니다.");
            }
            else
            {
                System.Console.WriteLine("30 이상입니다.");
            }


            //짝홀 판별기

            if ((singlenumber ) == 0 && (singlenumber2) == 0)
            {
                System.Console.WriteLine("짝짝");
            }
            else if ((singlenumber) == 0 && (singlenumber2) == 1)
            {
                System.Console.WriteLine("짝홀");
            }
            else if ((singlenumber) == 1 && (singlenumber2) == 0)
            {
                System.Console.WriteLine("홀짝");
            }
            else if ((singlenumber) == 1 && (singlenumber2) == 1)
            {
                System.Console.WriteLine("홀홀");
            }



        }
    }
}
