using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //나이에 해당하는 띠를 출력해줄 클래스를 만든다.
            //탄생년도를 입력하면 해당하는 띠를 출력한다.
            //출력할때 만 나이도 같이 계산되어 출력된다.

            animal Aanimal = new animal();
            Aanimal.InputAnimalInfoData();


        }
    }
    class animal
    {

        public string year;
        public int convertyear;


        public string[] aa;



        public void InputAnimalInfoData()
        {
            aa = new string[12] { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };
            System.Console.WriteLine("당신의 탄생년도가 언제입니까?");
            year = System.Console.ReadLine();
            convertyear = Convert.ToInt32(year);

            System.Console.WriteLine(aa[convertyear % 12]);
        }

    }
}
