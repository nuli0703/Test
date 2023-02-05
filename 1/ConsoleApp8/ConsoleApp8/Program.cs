using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("0");
            //메소드
            int newInt = ShowUpNewSentence(5);
            int newInt2 = ShowUpNewSentence(55);
            int newInt3 = ShowUpNewSentence(555);
            int newInt4 = ShowUpNewSentence(5555);

            System.Console.WriteLine("3");

        }
        private static int ShowUpNewSentence(int number1)
        {
            int newNumber = number1 + 5;
            System.Console.WriteLine(newNumber);

            return newNumber;
        }


        private static int ShowUpNewSentence2(int number2)
        {
            int newNumber2 = number2 - 7;
            System.Console.WriteLine(newNumber2);

            return newNumber2;
        }

        private static int ShowUpNewSentence3(int number3)
        {
            int newNumber3 = number3 * 5;
            System.Console.WriteLine(newNumber3);

            return newNumber3;

        }
        private static int ShowUpNewSentence4(int number4)
        {
            int newNumber4 = number4 % 5;
            System.Console.WriteLine(newNumber4);

            return newNumber4;
        }

        }
}
