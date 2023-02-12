using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //public     - 외부에서 자유롭게 사용
            //private    - 나만 쓸 수 있다
            //protected  - 상속받은 자식이 쓸 수 있다.
        }


    }
    class GameClass
    {
        public string[] Games = new string[3] { "a", "b", "c" };

        public void searchGame()
        {
            string searchGameName = System.Console.ReadLine();
            for(int index = 0; index < 10; index++)
            {
                if(Games[index] == searchGameName)
                {
                    System.Console.WriteLine("있습니다.");
                    break;
                }
                if(index == 2)
                {
                    System.Console.WriteLine("없습니다.");
                    break;

                }
            }

        }



    }
}
