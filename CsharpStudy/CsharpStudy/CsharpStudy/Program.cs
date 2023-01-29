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

            //int형 배열 5칸짜리 5개
            //stirng 형 배열 5칸짜리 5개

            int[] iiii = new int[5] { 3, 4, 5, 6, 7 };
            int[] iiiii = new int[5] { 8, 9, 10, 11, 12 };
            int[] iiiiii = new int[5] { 13, 14, 15, 16, 17 };
            int[] iiiiiii = new int[5] { 18, 19, 20, 21, 22 };
            int[] iiiiiiii = new int[5] { 23, 24, 25, 26, 27 };

            string[] aaaa = new string[5] { "A", "B", "C", "D", "E" };
            string[] aaaaa = new string[5] { "A", "B", "C", "D", "E" };
            string[] aaaaaa = new string[5] { "A", "B", "C", "D", "E" };
            string[] aaaaaaa = new string[5] { "A", "B", "C", "D", "E" };
            string[] aaaaaaaa = new string[5] { "A", "B", "C", "D", "E" };

            int[] LaterArray;

            System.Console.WriteLine("배열의 크기는?");
            string ArraySize;
            ArraySize = System.Console.ReadLine();

            LaterArray = new int[Convert.ToInt32(ArraySize)];

            string[] _lang = new string[3];
            _lang[0] = "c";
            _lang[1] = "c++";
            _lang[2] = "c#";

            System.Console.WriteLine($"0번 값은 {_lang[0]}입니다");
            _lang[0] = "나도 졸려";

            System.Console.WriteLine($"0번 값은 {_lang[0]}입니다");


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
