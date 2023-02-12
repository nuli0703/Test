using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //게임들을 보유하고 있는 게임 클래스를 제작한다
            //게임을 입력하면 배열에 값이 있는지 비교해서 있는지 없는지 출력해준다.

            game Game = new game();
            Game.InputGameInfoData();

        }
    }
    class game
    {
        public string Ggame2; 
        public string[] Ggame;

    public void InputGameInfoData()
    {
            Ggame = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };
            System.Console.WriteLine("검색할 게임을 입력해주세요");
            Ggame2 = System.Console.ReadLine();

            if (Ggame2 == Ggame[0])
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

        }
}
}
