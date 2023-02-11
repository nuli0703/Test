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
            string number3;

            int convertnumb1;
            int convertnumb2;
            int convertnumb3;

            System.Console.WriteLine("대입할 첫번째 숫자를 입력해주세요");
            number1 = System.Console.ReadLine();
            convertnumb1 = Convert.ToInt32(number1);
            System.Console.WriteLine();

            System.Console.WriteLine("대입할 두번째 숫자를 입력해주세요");
            number2 = System.Console.ReadLine();
            convertnumb2 = Convert.ToInt32(number2);
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================");

            int plresult = convertnumb1 + convertnumb2;
            System.Console.WriteLine($"더하기 결과: {plresult}");

            int minusresult = convertnumb1 - convertnumb2;
            System.Console.WriteLine($"빼기 결과 : {minusresult}");

            int mulresult = convertnumb1 * convertnumb2;
            System.Console.WriteLine($"곱하기 결과 : {mulresult}");

            int quotresult = convertnumb1 / convertnumb2;
            System.Console.WriteLine($"나누기(몫) : {quotresult}");

            int reamresult = convertnumb1 % convertnumb2;
            System.Console.WriteLine($"나누기(나머지) : {reamresult}");
            System.Console.WriteLine("===========================================");
            System.Console.WriteLine();

            //세번째
            System.Console.WriteLine("대입할 세번째 숫자를 입력해주세요");
            number3 = System.Console.ReadLine();
            convertnumb3 = Convert.ToInt32(number3);
            System.Console.WriteLine();

            System.Console.WriteLine("입력받았던 숫자들과 세번째 숫자를 사용한 결과입니다.");
            System.Console.WriteLine();
            System.Console.WriteLine("===========================================");

            int plresult2 = convertnumb1 + convertnumb2 + convertnumb3;
            System.Console.WriteLine($"더하기 결과: {plresult2}");

            int minusresult2 = convertnumb1 - convertnumb2 - convertnumb3;
            System.Console.WriteLine($"빼기 결과 : {minusresult2}");

            int mulresult2 = convertnumb1 * convertnumb2 * convertnumb3;
            System.Console.WriteLine($"곱하기 결과 : {mulresult2}");

            int quotresult2 = convertnumb1 / convertnumb2 / convertnumb3;
            System.Console.WriteLine($"나누기(몫) : {quotresult2}");

            int reamresult2 = convertnumb1 % convertnumb2 % convertnumb3;
            System.Console.WriteLine($"나누기(나머지) : {reamresult2}");
            System.Console.WriteLine("===========================================");
            System.Console.WriteLine();

            System.Console.WriteLine("===========================================");
            Console.WriteLine($"플러스 전위 증가 연산자 : {++plresult2}");
            Console.WriteLine($"플러스 후위 증가 연산자 : {plresult2++}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {--plresult2}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {plresult2--}");
            System.Console.WriteLine("===========================================");
            Console.WriteLine($"플러스 전위 증가 연산자 : {++minusresult2}");
            Console.WriteLine($"플러스 후위 증가 연산자 : {minusresult2++}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {--minusresult2}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {minusresult2--}");
            System.Console.WriteLine("===========================================");
            Console.WriteLine($"플러스 전위 증가 연산자 : {++mulresult2}");
            Console.WriteLine($"플러스 후위 증가 연산자 : {mulresult2++}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {--mulresult2}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {mulresult2--}");
            System.Console.WriteLine("===========================================");
            Console.WriteLine($"플러스 전위 증가 연산자 : {++quotresult2}");
            Console.WriteLine($"플러스 후위 증가 연산자 : {quotresult2++}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {--quotresult2}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {quotresult2--}");
            System.Console.WriteLine("===========================================");
            Console.WriteLine($"플러스 전위 증가 연산자 : {++reamresult2}");
            Console.WriteLine($"플러스 후위 증가 연산자 : {reamresult2++}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {--reamresult2}");
            Console.WriteLine($"마이너스 전위 증가 연산자 : {reamresult2--}");
        }
    }
}
