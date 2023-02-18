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
            star Star = new star();
            Star.InputStarInfoData();
        }
    }

    class star
    {
        public string Y;
        public int convertY;
        public int minY;

        public string[] Stars;

        public void InputStarInfoData()
        {
            Stars = new string[12] { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };
            System.Console.WriteLine("당신의 탄생년도가 언제입니까? 4자리의 숫자를 입력해주세요.");

            //비트 변환
            Y = System.Console.ReadLine();
            convertY = Convert.ToInt32(Y);

            System.Console.WriteLine(Stars[convertY % 12]);
            minY = 2023 - convertY + 1;

            System.Console.WriteLine("당신의 나이는 " + minY  + " 입니다.");

        }

    }



}
