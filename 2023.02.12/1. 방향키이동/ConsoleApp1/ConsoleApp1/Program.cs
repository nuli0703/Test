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
            #region 키 입력하는 부분
            ConsoleKeyInfo cski;

            int x = 10;
            int y = 10;

            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(x, y);

                Console.Write("#");

                cski = Console.ReadKey(true);
                switch(cski.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;

                }

            }
            #endregion











        }
    }
}
