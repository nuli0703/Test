using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Restaurant
        {
            public virtual string[] GetMenu()
            {
                return null;
            }

            public virtual int ChargeMoney(string menu)
            {
                return 0;
            }

            public virtual void ServeFood(string menu)
            {
                Console.WriteLine($"주문하신 {menu} 나왔습니다.");
            }
        }

        public class KoreanRestaurant : Restaurant
        {
            public override string[] GetMenu()
            {
                return new string[] { "삼계탕", "냉면", "제육볶음" }; // 한식 메뉴
            }

            public override int ChargeMoney(string menu)
            {
                switch (menu)
                {
                    case "삼계탕":
                        return 20000;
                    case "냉면":
                        return 10000;
                    case "제육볶음":
                        return 9000;
                    default:
                        return 0;
                }
            }
        }

        public class WesternRestaurant : Restaurant
        {
            public override string[] GetMenu()
            {
                return new string[] { "스테이크", "파스타", "샐러드" }; // 양식 메뉴
            }

            public override int ChargeMoney(string menu)
            {
                switch (menu)
                {
                    case "스테이크":
                        return 30000;
                    case "파스타":
                        return 20000;
                    case "샐러드":
                        return 9000;
                    default:
                        return 0;
                }
            }
        }

        public class ChineseRestaurant : Restaurant
        {
            public override string[] GetMenu()
            {
                return new string[] { "짜장면", "짬뽕", "탕수육" }; // 중식 메뉴
            }

            public override int ChargeMoney(string menu)
            {
                switch (menu)
                {
                    case "짜장면":
                        return 7000;
                    case "짬뽕":
                        return 8000;
                    case "탕수육":
                        return 15000;
                    default:
                        return 0;
                }
            }
        }

        public class choose
        {
            public static void Main()
            {
                Console.WriteLine("한식, 양식, 중식 중에서 가고 싶은 식당을 선택하세요.");
                string restaurant = Console.ReadLine().Trim().ToLower();
                Restaurant chosenRestaurant = null;

                switch (restaurant)
                {
                    case "한식":
                        chosenRestaurant = new KoreanRestaurant();
                        break;
                    case "양식":
                        chosenRestaurant = new WesternRestaurant();
                        break;
                    case "중식":
                        chosenRestaurant = new ChineseRestaurant();
                        break;
                    default:
                        return;

                }
            }
        }
    }
}
