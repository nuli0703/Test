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
        //    int number1 = 10;
            int number2 = 16;

            int plusResult = number1 + number2;
            int minusResult = number1 - number2;
            int multResult = number1 * number2;
            int quioResult = number1 / number2; //몫
            int reminResult = number1 % number2; //나머지
            System.Console.WriteLine($"Plus result : {plusResult}");
            System.Console.WriteLine($"minus result : {minusResult}");
            System.Console.WriteLine($"mult result : {multResult}");
            System.Console.WriteLine($"quio result : {quioResult}");
            System.Console.WriteLine($"remin result : {reminResult}");

            //할당연산자
            int number11 = 123;
            int number21 = 532;
            number21 += number11;
            System.Console.WriteLine($"PP result : {number21}");

            int number33 = 123;
            int number31 = 532;
            number33 -= number31;
            System.Console.WriteLine($"MM result : {number31}");

            int number44 = 123;
            int number41 = 532;
            number44 *= number41;
            System.Console.WriteLine($"ML result : {number41}");

            int number55 = 123;
            int number51 = 532;
            number55 /= number51;
            System.Console.WriteLine($"QU result : {number51}");

            int number66 = 123;
            int number61 = 532;
            number66 %= number61;
            System.Console.WriteLine($"RE result : {number61}");



            int vale = 123;
            System.Console.WriteLine($"result : {++vale}");
            System.Console.WriteLine($"result : {vale}");
            System.Console.WriteLine($"result : {vale++}");
            System.Console.WriteLine($"result : {vale}");

            const int theNumber = 10;


            bool isName = true;
            // ! 앞에 붙으면 반전
            bool isnName = !true;


            // == 같다
            // != 다르다
            // < 작다
            // > 크다
            // <= 작거나 같다
            // >= 크거나 같다

            bool issame = (3 == 3);
            System.Console.WriteLine(issame); //ture

            bool issame2 = (true == false);
            System.Console.WriteLine(issame2); //false

            bool isDif = ("hello" != "hello");
            System.Console.WriteLine(isDif); //false

            bool small = (3 < 4);
            System.Console.WriteLine(small); //ture

            bool big = (4 > 3);
            System.Console.WriteLine(big); //ture



            bool isTrue = true;
            bool isFalse = false;

            bool isAnd = (isTrue && isFalse);
            bool isOr = (isTrue || isFalse);


            System.Console.WriteLine(true && true); //ture
            System.Console.WriteLine(true && false); //false
            System.Console.WriteLine(false && true); //false
            System.Console.WriteLine(false && false); // false

            System.Console.WriteLine(true || true); //true
       //     System.Console.WriteLine(true || false); //true
        //    System.Console.WriteLine(false || true); //true
         //   System.Console.WriteLine(false || false); //false


            // bool T = true;
            //     bool F = false;

            //     bool isAAnd = (T && F);
            //    bool isOOr = (T || F);


            //     System.Console.WriteLine(true && true); //ture
            //     System.Console.WriteLine(true && false); //false
            //     System.Console.WriteLine(false && true); //false
            //     System.Console.WriteLine(false && false); // false

            //     System.Console.WriteLine(true || true); //true
            //    System.Console.WriteLine(true || false); //true
            //    System.Console.WriteLine(false || true); //true
            //    System.Console.WriteLine(false || false); //false

            if (true)
            {
                System.Console.WriteLine("if문 false 실행");
            }

        }
    }
}
