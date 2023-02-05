using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1;
            string number2;

            int number11;
            int number22;


            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            number1 = System.Console.ReadLine();
            number11 = Convert.ToInt32(number1);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            number2 = System.Console.ReadLine();
            number22 = Convert.ToInt32(number2);


            if (number11 % 2 == 0 && number22 < 0)
            {
                System.Console.WriteLine("A가 짝수이고 B가 0보다 작음");
            }
            else if (number11 % 2 == 0 && number22 < 3)
            {
                System.Console.WriteLine("A가 짝수이고 B가 3보다 작음");
            }
            else if (number11 % 2 == 1 && number22 < 5)
            {
                System.Console.WriteLine("A가 홀수이고 B가 5보다 작음");
            }
            else
            {
                System.Console.WriteLine("해당하는 조건이 없습니다");
            }
        }
    }
}
