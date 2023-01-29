using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "김누리";
            int ii = 3;
            float fff = 3.12f;


            //값을 가져올건데 int, string, char 형인지 모를때
            var MyNameis = "김누리";
            var iii = 3;
            var fffff = 3.12f;
            //정수형배열

            int[] kkk = new int[4] { 89, 6, 456, 4 };
            string[] lang = new string[3] { "C#", "C++", "C" };
            long[] lolo = new long[1] { 2 };
            /// kkk -> 89 , 6, 456, 4
            //lang -> C# , C++ , C






            //식당에 음식이 떡볶이, 김밥, 라면, 라볶이가 있다.

            string[] _food = new string[4];
            _food[0] = "떡볶이";
            _food[1] = "김밥";
            _food[2] = "라면";
            _food[3] = "라볶이";




            //이중에 숫자를 입력받으면
            //입력받은 값은 비어있게된다.

            System.Console.WriteLine($"1번 메뉴는 {_food[0]}입니다.");

            System.Console.WriteLine($"2번 메뉴는 {_food[1]}입니다.");

            System.Console.WriteLine($"3번 메뉴는 {_food[2]}입니다.");

            System.Console.WriteLine($"4번 메뉴는 {_food[3]}입니다.");



            //최초 음식들과
            //숫자를 입력받았을때 음식을 출력하고


            string Order;

            System.Console.WriteLine("주문할 음식은?");
            Order = System.Console.ReadLine();

            int number = Convert.ToInt32(Order);

            _food[number] = "";


            System.Console.WriteLine($"1번 메뉴는 {_food[0]}입니다.");

            System.Console.WriteLine($"2번 메뉴는 {_food[1]}입니다.");

            System.Console.WriteLine($"3번 메뉴는 {_food[2]}입니다.");

            System.Console.WriteLine($"4번 메뉴는 {_food[3]}입니다.");



            //비어있게 되었다라는 결과값도 출력하라









            //1. 변수형 종류 주석으로 작성후, 각 변수형들의 최대값 최소값으로 출력하기
            int kk = int.MaxValue;
            int k2 = int.MinValue;

            System.Console.WriteLine(kk.ToString());
            System.Console.WriteLine(k2.ToString());



            //2. string으로 이름 나이 입력받고, 출력하기
            //나이는 출생년도만 입력받기

            string myName;
            string myYear;

            System.Console.WriteLine("당신의 이름은 무엇인가요 : ");
            myName = System.Console.ReadLine();
            System.Console.WriteLine("당신의 출생년도는 언제인가요 : ");
            myYear = System.Console.ReadLine();
            int kkkkkk = Convert.ToInt32(myYear);
            int myCurAge = 2023 - kkkkkk;



            //3. @사용 해서 별 그리기
            System.Console.WriteLine(@"
ㅁ                 ㅁ                    ㅁ
ㅁㅁ              ㅁㅁ                   ㅁㅁ
ㅁㅁㅁ           ㅁㅁㅁ                  ㅁㅁ
  ㅁㅁㅁ       ㅁㅁㅁㅁㅁㅁ             ㅁㅁ
   ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ ㅁㅁㅁ 
  ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ 
   ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
  ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ
ㅁㅁㅁㅁㅁㅁㅁ             ㅁㅁㅁㅁㅁㅁㅁㅁ
    ㅁㅁㅁㅁ               ㅁㅁㅁㅁ
   ㅁㅁㅁㅁ                 ㅁㅁㅁㅁ
ㅁㅁㅁㅁ                      ㅁㅁㅁㅁ");






            //4. int값을 double로 캐스팅하기
            int k3 = 3;
            double mmm = k3;

            System.Console.WriteLine(mmm.ToString());

            //4-1. 3.12를 int값으로 캐스팅 하기
            float k4 = 3.12f;

            System.Console.WriteLine(k4.ToString());


            //이름을 입력받는다.
            //입력받은 이름의 길이를 숫자로 바꾸고
            //받은 숫자를 출력한다.


        }
    }
}
