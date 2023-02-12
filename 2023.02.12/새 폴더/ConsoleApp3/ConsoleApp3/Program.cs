using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. 먹을 것 클래스를 만들어서 음식을 여러개 입력받습니다. (Readline())
            //-1. 5개의 음식을 입력 받습니다.
            //-2. 추가로 음식을 입력받는데, 5개의 음식중 이미 있는 음식이면 제외됩니다.
            //예) a,b,c,d,e 가 있는데 추가로 b가 입력됨
            //    -> a,c,d,e 가 되다.

            Food AFood = new Food();
            AFood.InputFoodInfoData();


        }

    }
    class Food
    {
        public string fname1;
        public string fname2;
        public string fname3;
        public string fname4;
        public string fname5;
        public string fname6;
        public void InputFoodInfoData()
        {
            System.Console.WriteLine("첫번째 음식의 이름은?");
            fname1 = System.Console.ReadLine();
            System.Console.WriteLine("두번째 음식의 이름은?");
            fname2 = System.Console.ReadLine();
            System.Console.WriteLine("세번째 음식의 이름은?");
            fname3 = System.Console.ReadLine();
            System.Console.WriteLine("네번째 음식의 이름은?");
            fname4 = System.Console.ReadLine();
            System.Console.WriteLine("다섯번째 음식의 이름은?");
            fname5 = System.Console.ReadLine();


            WritelineFoodInfo();
        }
        public void WritelineFoodInfo()
        {
            System.Console.WriteLine($"첫번째 음식의 이름은 {fname1}");
            System.Console.WriteLine($"두번째 음식의 이름은 {fname2}");
            System.Console.WriteLine($"세번째 음식의 이름은 {fname3}");
            System.Console.WriteLine($"네번째 음식의 이름은 {fname4}");
            System.Console.WriteLine($"다섯번째 음식의 이름은 {fname5}");

            System.Console.WriteLine("추가로 입력할 음식의 이름은?");
            fname6 = System.Console.ReadLine();

            if(fname6 == fname1)
            {
                fname1 = "";
            }
            else if (fname6 == fname2)
            {
                fname2 = "";
            }

            else if (fname6 == fname3)
            {
                fname3 = "";
            }

            else if (fname6 == fname4)
            {
                fname4 = "";
            }

            else if (fname6 == fname5)
            {
                fname5 = "";
            }

            System.Console.WriteLine($"첫번째 음식의 이름은 {fname1}");
            System.Console.WriteLine($"두번째 음식의 이름은 {fname2}");
            System.Console.WriteLine($"세번째 음식의 이름은 {fname3}");
            System.Console.WriteLine($"네번째 음식의 이름은 {fname4}");
            System.Console.WriteLine($"다섯번째 음식의 이름은 {fname5}");
        }


    }
}

