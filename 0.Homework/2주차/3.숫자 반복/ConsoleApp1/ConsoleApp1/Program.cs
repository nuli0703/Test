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

            System.Console.WriteLine("반복할 숫자를 입력해주세요");
            number1 = System.Console.ReadLine();

            //변환
            int connumber1 = Convert.ToInt32(number1);
            System.Console.WriteLine();

            System.Console.WriteLine("for문으로 반복을 시작합니다");
            for(int a = 0; a < connumber1; a++)
            {
                System.Console.WriteLine(a + 1 + "번째 문장반복중");
            }
            System.Console.WriteLine();


            int aa = 0;
            System.Console.WriteLine("While문으로 반복을 시작합니다");
            while (aa < connumber1)
            {
           
                System.Console.WriteLine(aa + 1+ "번째 문장반복중");
                aa++;
            }

        }
    }
}
