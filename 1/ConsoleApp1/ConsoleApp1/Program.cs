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
            // 주석

            string name;
            string birth;
            string W;
            string you;


            // 베이스
            System.Console.WriteLine("==================================");
            System.Console.WriteLine("이름을 입력해주세요.");
            name = System.Console.ReadLine();
            System.Console.WriteLine();

            System.Console.WriteLine("==================================");
            System.Console.WriteLine("생년 4자리를 입력해주세요.");
            birth = System.Console.ReadLine();
            System.Console.WriteLine();

            //변환
            int age = Convert.ToInt32(birth);
            age = 2023 - age + 1;

            System.Console.WriteLine("==================================");
            System.Console.WriteLine("자기소개를 입력해주세요.");
            W = System.Console.ReadLine();
            System.Console.WriteLine();

            //나이
            System.Console.WriteLine("==================================");
            System.Console.WriteLine("당신의 나이는" + age + "입니다.");
            System.Console.WriteLine();

            //이름
            System.Console.WriteLine($"당신의 이름은 {name} 입니다");

            //도형
            System.Console.WriteLine();
            System.Console.WriteLine("@@@@");
            System.Console.WriteLine("@@@@");
            System.Console.WriteLine("@@@@");
            System.Console.WriteLine();

            //배열넣기
            string[] stringValues = new string[3];
            stringValues[0] = name;
            stringValues[1] = birth;
            stringValues[2] = W;

            //4번방식
            System.Console.WriteLine();
            System.Console.WriteLine(stringValues[0]);
            System.Console.WriteLine(stringValues[1]);
            System.Console.WriteLine(stringValues[2]);
            System.Console.WriteLine();

            //5번방식
            System.Console.WriteLine($"{stringValues[0]},{stringValues[1]},{stringValues[2]}");

        }
    }
}
