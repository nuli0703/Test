using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string //
            string name;
            string birthday;
            string adress;
            string gender;
            string W;

            // 질문 //
            System.Console.WriteLine("당신의 성함은 무엇입니까?");
            name = System.Console.ReadLine();

            System.Console.WriteLine("당신은 몇년도에 태어났습니까?");
            birthday = System.Console.ReadLine();

            System.Console.WriteLine("당신의 거주지의 주소가 어디입니까?");
            adress = System.Console.ReadLine();

            System.Console.WriteLine("당신의 성별은 어떻게됩니까?");
            gender = System.Console.ReadLine();

            System.Console.WriteLine("자기소개를 해주시겠습니까?");
            W = System.Console.ReadLine();


            // 3줄 띄우기//
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            // 나이변환 //
            int age = Convert.ToInt32(birthday);
            age = 2023 - age + 1;

            // 답변 //
            System.Console.WriteLine("당신의 이름은 " + name + " 입니다");
            System.Console.WriteLine("당신의 나이는 " + age + "세입니다");
            System.Console.WriteLine("당신의 주소는 " + adress + " 입니다");
            System.Console.WriteLine("당신의 성별은 " + gender + " 입니다");

            System.Console.WriteLine();
            System.Console.WriteLine("아래부터는, 당신이 작성한 자개소개입니다");
            System.Console.WriteLine();
            System.Console.WriteLine(W);
        }
    }
}
