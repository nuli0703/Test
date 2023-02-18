using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.식당 클래스를 상속받는 한식 / 양식 /중식

            //식당 클래스가 전체적으로
            //가질 정보들을 갖는다
            //( 돈 받기 / 주문한 음식 주기 )

            //각각 식당들은 메뉴가 모두 다르다.
            //한식은 삼계탕 1만원 등등 다르다.
            //가고싶은 식당을 입력받고, 메뉴를 모두 띄워준다.
            //유저는 메뉴를 입력하고, 내야할 가격, 고른 메뉴를 띄워준다.
            shop Shop = new shop();
            Shop.InputShopInfoData();
         

        }
        class shop
        {
            protected int[] menusPrice;
            


            public void TakeMoney(int money)
            {
                System.Console.WriteLine($"돈 내기 : {money}")
            }




            public void OrderMenu(int number)
            {
                System.Console.WriteLine($"주문 : {menus[number]}");
                TakeMoney(menusPrice[number]);

            }
            public void ShowMenu()
            {
                for (int i = 0; i < menusPric)

            }
        }
    }
}
