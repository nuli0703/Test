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
            //1. 산술 이항 하나씩 쓰기 (+ - * / %), 출력하기 5줄


            //int a = 3;
            //int b = 4;

            //int c = a + b;
            //int d = a - b;
            //int e = a * b;
            //int f = a / b;

            //System.Console.WriteLine($"+ : {c}");
            //System.Console.WriteLine($"- : {d}");
            //System.Console.WriteLine($"* : {e}");
            //System.Console.WriteLine($"/ : {f}");
            //System.Console.WriteLine();



            ////2. 할당 (+= , -= , ...), 출력하기 5줄
            //c += 2;
            //d -= 2;
            //e *= 2;
            //f /= 2;
            //System.Console.WriteLine($"+ : {c}");
            //System.Console.WriteLine($"- : {d}");
            //System.Console.WriteLine($"* : {e}");
            //System.Console.WriteLine($"/ : {f}");
            //System.Console.WriteLine();




            ////3. 증감 (++, --) 앞뒤로 4줄
            //Console.WriteLine($"플러스 전위 증가 연산자 : {++c}");
            //Console.WriteLine($"플러스 후위 증가 연산자 : {c++}");
            //Console.WriteLine($"마이너스 전위 증가 연산자 : {--c}");
            //Console.WriteLine($"마이너스 전위 증가 연산자 : {c--}");
            //System.Console.WriteLine();



            //4. 2개 숫자 입력후 A가 짝수 이고 B가 5보다 큰가를 if문으로
            System.Console.WriteLine("4. 2개 숫자 입력후 A가 짝수 이고 B가 5보다 큰가를 if문으로");
            string Number1;
            string Number2;
            int Number11;
            int Number22;

            int singleN1;




            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            Number1 = System.Console.ReadLine();
            Number11 = Convert.ToInt32(Number1);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            Number2 = System.Console.ReadLine();
            Number22 = Convert.ToInt32(Number2);

            singleN1 = Number11 % 2;

            if ((singleN1) == 0 && (Number22) > 5)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 5보다 큽니다");
            }
            if ((singleN1) == 1 && (Number22) > 5)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 5보다 큽니다");
            }
            if ((singleN1) == 1 && (Number22) < 5)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 5보다 작습니다");
            }
            if ((singleN1) == 0 && (Number22) < 5)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 5보다 작습니다");
            }
            System.Console.WriteLine();



            //5. 2개 숫자 입력후 A가 홀수 이거나 B가 3보다 작은가를 elseIf문으로
            System.Console.WriteLine("5.2개 숫자 입력후 A가 홀수 이거나 B가 3보다 작은가를 elseIf문으로");
            string Number3;
            string Number4;
            int Number33;
            int Number44;

            int singleN3;




            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            Number3 = System.Console.ReadLine();
            Number33 = Convert.ToInt32(Number3);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            Number4 = System.Console.ReadLine();
            Number44 = Convert.ToInt32(Number4);

            singleN3 = Number33 % 2;

            if ((singleN3) == 0 && (Number44) > 3)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 3보다 큽니다");
            }
            else if ((singleN3) == 1 && (Number44) > 3)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 3보다 큽니다");
            }
            else if ((singleN3) == 1 && (Number44) < 3)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 3보다 작습니다");
            }
            else if ((singleN3) == 0 && (Number44) < 3)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 3보다 작습니다");
            }
            else
            {
                System.Console.WriteLine("일치하는 결과가 없습니다");
            }



            //6. else 문으로 없음 출력하기
            System.Console.WriteLine("6.else 문으로 없음 출력하기");
            string Number5;
            string Number6;
            int Number55;
            int Number66;

            int singleN5;




            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            Number5 = System.Console.ReadLine();
            Number55 = Convert.ToInt32(Number5);


            if ((Number55) < 5)
            {
                System.Console.WriteLine("두번째 숫자는 5보다 작습니다");
            }
            else if ((Number55) < 4)
            {
                System.Console.WriteLine("두번째 숫자는 4보다 작습니다");
            }
            else if ((Number55) < 3)
            {
                System.Console.WriteLine("두번째 숫자는 3보다 작습니다");
            }
            else if ((Number55) < 2)
            {
                System.Console.WriteLine("두번째 숫자는 2보다 작습니다");
            }
            else
            {
                System.Console.WriteLine("일치하는 조건이 없습니다");
            }



            //7.숫자를 입력받은거 만큼 문장 출력 (while)
            System.Console.WriteLine();
            string whilenumber;

            System.Console.WriteLine("반복할 숫자를 입력해주세요");
            whilenumber = System.Console.ReadLine();

            int whilenumber11 = Convert.ToInt32(whilenumber);
            System.Console.WriteLine();

            int cycle = 0;
            System.Console.WriteLine("While문으로 반복합니다");
            while (cycle < whilenumber11)
            {
                System.Console.WriteLine(cycle + 1 + "번째 문장 반복중");
                cycle++;
            }


            //8. 숫자 입력받은거 만큼 문장출력 (for)
            System.Console.WriteLine();

            System.Console.WriteLine("for문으로 출력합니다.");
            for (int cycle2 = 0; cycle2 < whilenumber11; cycle2++)
            {
                System.Console.WriteLine(cycle2 + 1 + "번째 문장 반복 중");
            }




            //9. 위에 했던 4.5.6.7.8을 메소드로 뽑아서 실행하기
            System.Console.WriteLine();

            System.Console.WriteLine("메소드 시작");
            method45678();

            System.Console.WriteLine();
            System.Console.WriteLine();














        }
        private static void method45678()
        {
            System.Console.WriteLine("4. 2개 숫자 입력후 A가 짝수 이고 B가 5보다 큰가를 if문으로");
            string Number1;
            string Number2;
            int Number11;
            int Number22;

            int singleN1;




            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            Number1 = System.Console.ReadLine();
            Number11 = Convert.ToInt32(Number1);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            Number2 = System.Console.ReadLine();
            Number22 = Convert.ToInt32(Number2);

            singleN1 = Number11 % 2;

            if ((singleN1) == 0 && (Number22) > 5)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 5보다 큽니다");
            }
            if ((singleN1) == 1 && (Number22) > 5)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 5보다 큽니다");
            }
            if ((singleN1) == 1 && (Number22) < 5)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 5보다 작습니다");
            }
            if ((singleN1) == 0 && (Number22) < 5)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 5보다 작습니다");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("5.2개 숫자 입력후 A가 홀수 이거나 B가 3보다 작은가를 elseIf문으로");
            string Number3;
            string Number4;
            int Number33;
            int Number44;

            int singleN3;




            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            Number3 = System.Console.ReadLine();
            Number33 = Convert.ToInt32(Number3);

            System.Console.WriteLine("두번째 숫자를 입력해주세요");
            Number4 = System.Console.ReadLine();
            Number44 = Convert.ToInt32(Number4);

            singleN3 = Number33 % 2;

            if ((singleN3) == 0 && (Number44) > 3)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 3보다 큽니다");
            }
            else if ((singleN3) == 1 && (Number44) > 3)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 3보다 큽니다");
            }
            else if ((singleN3) == 1 && (Number44) < 3)
            {
                System.Console.WriteLine("첫번째 숫자는 홀수이고, 두번째 숫자는 3보다 작습니다");
            }
            else if ((singleN3) == 0 && (Number44) < 3)
            {
                System.Console.WriteLine("첫번째 숫자는 짝수이고, 두번째 숫자는 3보다 작습니다");
            }
            else
            {
                System.Console.WriteLine("일치하는 결과가 없습니다");
            }
            System.Console.WriteLine("6.else 문으로 없음 출력하기");
            string Number5;
            string Number6;
            int Number55;
            int Number66;

            int singleN5;




            System.Console.WriteLine("첫번째 숫자를 입력해주세요");
            Number5 = System.Console.ReadLine();
            Number55 = Convert.ToInt32(Number5);


            if ((Number55) < 5)
            {
                System.Console.WriteLine("두번째 숫자는 5보다 작습니다");
            }
            else if ((Number55) < 4)
            {
                System.Console.WriteLine("두번째 숫자는 4보다 작습니다");
            }
            else if ((Number55) < 3)
            {
                System.Console.WriteLine("두번째 숫자는 3보다 작습니다");
            }
            else if ((Number55) < 2)
            {
                System.Console.WriteLine("두번째 숫자는 2보다 작습니다");
            }
            else
            {
                System.Console.WriteLine("일치하는 조건이 없습니다");
            }
            System.Console.WriteLine();
            string whilenumber;

            System.Console.WriteLine("반복할 숫자를 입력해주세요");
            whilenumber = System.Console.ReadLine();

            int whilenumber11 = Convert.ToInt32(whilenumber);
            System.Console.WriteLine();

            int cycle = 0;
            System.Console.WriteLine("While문으로 반복합니다");
            while (cycle < whilenumber11)
            {
                System.Console.WriteLine(cycle + 1 + "번째 문장 반복중");
                cycle++;
            }
            System.Console.WriteLine();

            System.Console.WriteLine("for문으로 출력합니다.");
            for (int cycle2 = 0; cycle2 < whilenumber11; cycle2++)
            {
                System.Console.WriteLine(cycle2 + 1 + "번째 문장 반복 중");
            }
        }
    }
}
