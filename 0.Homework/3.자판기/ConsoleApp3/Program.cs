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
            string choose;
            string[] Foods;
            

            Foods = new string[4] { "떡볶이", "김밥", "만두", "튀김" };

            System.Console.WriteLine("분식집 메뉴입니다. 무엇을 고르시겠습니까?");
            System.Console.WriteLine();
            System.Console.WriteLine(Foods[0]);
            System.Console.WriteLine(Foods[1]);
            System.Console.WriteLine(Foods[2]);
            System.Console.WriteLine(Foods[3]);
            System.Console.WriteLine();
            System.Console.WriteLine("어떤걸 드시겠습니까?");
            choose = System.Console.ReadLine();

            //변환//
            int ate = Convert.ToInt32(choose);

            System.Console.WriteLine(Foods[ate] + "을 드셨습니다.");
            Foods[ate] = "";

            System.Console.WriteLine();
            System.Console.WriteLine("아래, 남은 메뉴입니다.");
            System.Console.WriteLine();
            System.Console.WriteLine(Foods[0]);
            System.Console.WriteLine(Foods[1]);
            System.Console.WriteLine(Foods[2]);
            System.Console.WriteLine(Foods[3]);
            System.Console.WriteLine();
            System.Console.WriteLine("감사합니다.");
            System.Console.WriteLine();


        }
    }
}
