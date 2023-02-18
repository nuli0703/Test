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
            calculator Calculator = new calculator();
            Calculator.InputcalculatorInfoData();
        }
    }





    class calculator
    {
        public string Firstnumber;
        public string Secondnumber;
        public string Sign;

        public int convertFirstnumber;
        public int convertSecondnumber;

        public int AA;


        public void InputcalculatorInfoData()
        {
            System.Console.WriteLine("첫번째 숫자를 입력해주세요.");
            Firstnumber = System.Console.ReadLine();
            convertFirstnumber = Convert.ToInt32(Firstnumber);


            System.Console.WriteLine();

            System.Console.WriteLine("두번째 숫자를 입력해주세요.");
            Secondnumber = System.Console.ReadLine();
            convertSecondnumber = Convert.ToInt32(Secondnumber);

            System.Console.WriteLine();

            System.Console.WriteLine("기호를 입력해주세요.");
            Sign = System.Console.ReadLine();

            switch (Sign)
            {

                case "+":
                    AA = convertFirstnumber + convertSecondnumber;
                    System.Console.WriteLine("두 수의 합은 " + AA + " 입니다.");
                    break;

                case "-":
                    AA = convertFirstnumber - convertSecondnumber;
                    System.Console.WriteLine("두 수의 마이너스는 " + AA + " 입니다.");
                    break;

                case "*":
                    AA = convertFirstnumber * convertSecondnumber;
                    System.Console.WriteLine("두 수의 곱하기는 " + AA + " 입니다.");
                    break;

                case "%":
                    AA = convertFirstnumber % convertSecondnumber;
                    System.Console.WriteLine("두 수의 나누기는 " + AA + " 입니다.");
                    break;


            }

        }
    }
}



