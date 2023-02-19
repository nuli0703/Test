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
            //// 랜덤 예시
            Random rand = new Random();
            int randomInt = rand.Next(0, 2);
            int randomInt2 = rand.Next(0, 2);
            string one, two;
            int re = 0, ree = 0;
            switch (randomInt)
            {
                case 0:
                    one = "가위";
                    re = 0;
                    break;
                case 1:
                    one = "바위";
                    re = 1;
                    break;
                case 2:
                    one = "보";
                    re = 2;
                    break;
            }

            switch (randomInt2)
            {
                case 0:
                    two = "가위";
                    ree = 0;
                    break;
                case 1:
                    two = "바위";
                    ree = 1;
                    break;
                case 2:
                    two = "보";
                    ree = 2;
                    break;


            }

            int playerone = 0;
            int playertwo = 0;

            bool i = true;
            System.Console.WriteLine("가위, 바위, 보 중, 왼손값을 입력해 주세요.");
            while (i)
            {


                string left = System.Console.ReadLine();
                if (left == "가위")
                {
                    playerone = 0;
                    i = false;
                }

                else if (left == "바위")
                {
                    playerone = 1;
                    i = false;
                }

                else if (left == "보")
                {
                    playerone = 2;
                    i = false;
                }

                else
                {

                    System.Console.WriteLine("잘못입력하셨습니다.");
                }
            }
            bool ii = true;
            System.Console.WriteLine("가위, 바위, 보 중, 오른손 값을 입력해 주세요.");
            while (ii)
            {
                string right = System.Console.ReadLine();
                if (right == "가위")
                {
                    playertwo = 0;
                    ii = false;
                }

                else if (right == "바위")
                {
                    playertwo = 1;
                    ii = false;
                }

                else if (right == "보")
                {
                    playertwo = 2;
                    ii = false;
                }

                else
                {

                    System.Console.WriteLine("잘못입력하셨습니다.");
                }
            }

            int randomInt3 = rand.Next(0, 2);
            int comResult = 0;
            switch (randomInt3)
            {
                case 0:
                    comResult = re;
                    break;
                case 1:
                    comResult = ree;
                    break;


            }

            int PlayerResult2 = 0;
            bool iii = true;
            if (iii)
            {
                System.Console.WriteLine("왼손과 오른손 중 어느 손을 고르시겠습니까?");
                string PlayerResult = System.Console.ReadLine();
                if (PlayerResult == "왼손")
                {
                    PlayerResult2 = playerone;

                }
                else if (PlayerResult == "오른손")
                {
                    PlayerResult2 = playertwo;
                }
            }


            System.Console.WriteLine("컴퓨터가 낸 값은");
            switch (comResult)
            {
                case 0:
                    System.Console.WriteLine("가위");
                    break;
                case 1:
                    System.Console.WriteLine("바위");
                    break;
                case 2:
                    System.Console.WriteLine("보");
                    break;
            }

            switch (playertwo)
            {
                case 0:
                    System.Console.WriteLine("가위");
                    one = "가위";
                    re = 0;
                    break;
                case 1:
                    System.Console.WriteLine("바위");
                    one = "바위";
                    re = 1;
                    break;
                case 2:
                    System.Console.WriteLine("보");
                    one = "보";
                    re = 2;
                    break;
            }
            Random rand = new Random();
            int randomInt = rand.Next(0, 2);
            int randomInt2 = rand.Next(0, 2);
            string one, two;
            int re = 0, ree = 0;

        }

    }
}
