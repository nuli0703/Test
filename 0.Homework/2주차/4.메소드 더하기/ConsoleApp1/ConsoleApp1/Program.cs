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
            int number11;
            int number22;


            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            number1 = System.Console.ReadLine();
            number11 = Convert.ToInt32(number1);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            number2 = System.Console.ReadLine();
            number22 = Convert.ToInt32(number2);

            System.Console.WriteLine();
            System.Console.WriteLine("메소드 시작");
            int aaa;

            aaa = plusnumber(number11, number22);

            System.Console.WriteLine(aaa);
            System.Console.WriteLine("끝");





        }

        private static int plusnumber(int mnumber1, int mnumber2)
        {
            int mnumber3;
            mnumber3 = mnumber1 + mnumber2;
            return mnumber3;
        }
    }
}
