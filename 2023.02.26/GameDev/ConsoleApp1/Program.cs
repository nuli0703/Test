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
            Player player = new Player();
            Menu.MenuInfoData1(player);




        }
    }

    public static class Menu
    {
        public static void MenuInfoData1(Player player)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.WriteLine("기지에 오신것을 환영합니다.");
            Console.WriteLine("어떤행동을 하실지 골라주십시오.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("1번 정찰활동");
            Console.WriteLine();
            Console.WriteLine("2번 연료 재보급");
            Console.WriteLine();
            Console.WriteLine("3번 차량 재정비");
            Console.WriteLine();
            Console.WriteLine("4번 차량 업그레이드");
            Console.WriteLine();
            Console.WriteLine("5번 물자상태");
            Console.WriteLine();
            Console.WriteLine("======================================================");

            Console.WriteLine();
            Basecamp.BaseInfoData1(player);
        }

    }
    public static class Basecamp
    {
        public static string BaseCampChoose1;
        public static int ConvertBaseCampNumber1;


        public static void BaseInfoData1(Player player)
        {
            Console.Write("숫자를 입력해주세요 : ");
            BaseCampChoose1 = Console.ReadLine();
            Console.WriteLine();
            ConvertBaseCampNumber1 = Convert.ToInt32(BaseCampChoose1);


            switch (BaseCampChoose1)
            {

                case "1":

                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("정찰 활동을 시작합니다.");
                    Order.BaseInfoData2(player);

                    break;



                case "2":
                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("연료 재보급을 실시합니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");

                    if (player.Ful < 140)
                    {
                        while (player.Ful < 140)
                        {
                            if (player.Ful == 140)
                            {
                                break;
                            }
                            player.Ful++;

                        }
                        Console.WriteLine("연료가 재보급을 완료했습니다.");
                        Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
                        Console.ReadLine();
                        Menu.MenuInfoData1(player);
                    }
                    else
                    {
                        Console.WriteLine("연료가 충분합니다.");
                        Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
                        Console.ReadLine();
                        Menu.MenuInfoData1(player);
                    }




                    break;

                case "3":
                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("전차를 재정비합니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");
                    if (player.HP < 3000)
                    {
                        while (player.HP < 3000)
                        {
                            if (player.HP == 3000)
                            {
                                break;
                            }
                            player.HP++;

                        }
                        Console.WriteLine("전차 수리를 완료했습니다.");
                        Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
                        Console.ReadLine();
                        Menu.MenuInfoData1(player);
                    }
                    else
                    {
                        Console.WriteLine("전차 상태가 최상입니다.");
                        Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
                        Console.ReadLine();
                        Menu.MenuInfoData1(player);
                    }
                    break;

                case "4":
                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("전차를 업그레이드합니다.");
                    Console.WriteLine("미구현 상태입니다. 엔터를 누르면, 이전 메뉴로 복귀합니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");
                    Console.ReadLine();
                    Menu.MenuInfoData1(player);

                    break;
                case "5":
                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("현재 보유하고있는 물자입니다.");
                    Console.WriteLine();
                    Console.WriteLine($"차량의 연료는 {player.Ful} 입니다.");
                    Console.WriteLine($"보유중인 철갑탄 수는 {player.APP} 입니다.");
                    Console.WriteLine($"보유중인 활동비는 {player.Money} 입니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
                    Console.ReadLine();
                    Menu.MenuInfoData1(player);

                    break;

                default:
                    Console.WriteLine("1번부터 5번 중 명령을 골라주세요.");
                    break;

            }
        }

    }

    public static class Order
    {
        public static string BaseCampChoose2;
        public static int ConvertBaseCampNumber2;

        public static void BaseInfoData2(Player player)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.WriteLine("정찰 명령어입니다.");
            Console.WriteLine("어떤행동을 하실지 골라주십시오.");
            Console.WriteLine();
            Console.WriteLine("1번 수색시작");
            Console.WriteLine("2번 차량 상태");
            Console.WriteLine("3번 기지 복귀");
            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.Write("숫자를 입력해주세요 : ");
            BaseCampChoose2 = Console.ReadLine();
            ConvertBaseCampNumber2 = Convert.ToInt32(BaseCampChoose2);

            switch (BaseCampChoose2)
            {

                case "1":

                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("수색을 진행합니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");
                    Serching.BaseInfoData3(player);
                    break;

                case "2":

                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("현재 차량 상태입니다.");
                    Console.WriteLine();
                    Console.WriteLine($"차량의 체력은 {player.HP} 입니다.");
                    Console.WriteLine($"차량의 주포 공격력은 {player.Att} 입니다.");
                    Console.WriteLine($"차량의 방어력은 {player.Def} 입니다.");
                    Console.WriteLine($"차량의 현재연료는 {player.Ful} 입니다.");
                    Console.WriteLine($"보유중인 철갑탄 수는 {player.APP} 입니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("엔터를 누르시면 이전메뉴로 복귀합니다.");
                    Console.ReadLine();
                    Console.WriteLine("======================================================");
                    Order.BaseInfoData2(player);
                    break;

                case "3":
                    Console.WriteLine("======================================================");
                    Console.WriteLine();
                    Console.WriteLine("기지로 복귀합니다.");
                    Console.WriteLine();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("엔터를 누르시면 이전메뉴로 복귀합니다.");
                    Console.WriteLine("======================================================");
                    Console.ReadLine();
                    Menu.MenuInfoData1(player);
                    break;
            }


        }



    }
    public class Entity
    {
        public virtual void Attack(Entity entity) { } //공격하기
        public virtual void Takedamage() { } //공격받기
        public virtual void Avoid() { } //회피하기
        public virtual void Reducehp() { } //피해받기
        
        


    }
    class PPlayer : Entity
    {
        public override void Attack(Entity entity)
        {
            System.Console.WriteLine("아군전차가 적을 공격함");
            entity.Takedamage();
        }
        public override void Avoid()
        {

            System.Console.WriteLine("아군전차가 공격을 회피함");
            System.Console.WriteLine();
        }
        public override void Reducehp()
        {

            System.Console.WriteLine($"아군전차가 데미지를 입음!");
            System.Console.WriteLine();
        }
        public override void Takedamage()
        {


        }


    }
    public class Serching
    {
        public static void Failss() { } //수색 실패
        public static void Sucs() { } //적 발견

        public static void BaseInfoData3(Player player)
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 8);
            if (randInt == 0) //0인 경우 수색실패
            {
                Failss();
                Console.WriteLine("======================================================");
                Console.WriteLine();
                Console.WriteLine("발견한것이 없습니다.");
                Console.WriteLine("엔터를 누르시면 이전메뉴로 복귀합니다.");
                Console.WriteLine();
                Console.WriteLine("======================================================");
                Console.ReadLine();
                Order.BaseInfoData2(player);

            }
            else //  적발견
            {
                Sucs();
                Console.WriteLine("======================================================");
                Console.WriteLine();
                Console.WriteLine("적을 발견하였습니다.");
                Console.WriteLine("미구현 상태입니다. 엔터를 누르면, 이전 메뉴로 복귀합니다.");
                Console.WriteLine();
                Console.WriteLine("======================================================");
                Console.ReadLine();
                Order.BaseInfoData2(player);
            }

        }
    }





    public class Player // 플레이어 차량 스탯
    {
        public int HP = 3000; // 차량 체력
        public int Def = 80; //차량 방어력
        public int Att = 100; // 주포 공격력
        public int APP = 0; //철갑탄 보유 수
        public int Ful = 120; // 연료
        public int Money = 0; // 보유금액


    }




    // 장갑 스탯들
    abstract class ESolArm //보병장갑
    {
        int LiteattackValue = 10; //데미지

        public abstract void AttackPlayer(Player player); // abstract

    }
    abstract class LightArm //경장갑
    {
        int LiteattackValue = 50; //데미지

        public abstract void AttackPlayer(Player player); // abstract

    }
    abstract class HeaveyArm // 중장갑
    {
        int HeaveyDefenceValue = 80; // 기본장갑

        public abstract void AttackPlayer(Player player); // abstract

    }





    // 적 스탯들
    class EBTR : LightArm // 적 장갑차 스탯
    {
        public override void AttackPlayer(Player player)
        {
            int LightAttackValue = 100; // 적 장갑차 공격력
            int LightHPValue = 500;
            System.Console.WriteLine("");

        }

    }
    class ETank : HeaveyArm // 적 전차 스탯
    {
        public override void AttackPlayer(Player player)
        {
            int HeaveyAttackValue = 100; // 적 전차 공격력
            int HeaveyHPValue = 800;
            System.Console.WriteLine("");

        }

    }
    class ESolRifle : ESolArm // 적 일반 보병 스탯
    {
        public override void AttackPlayer(Player player)
        {
            int SolAttackValue = 30; // 일반 보병 공격력
            int SolHPValue = 10;
            System.Console.WriteLine("");

        }

    }
    class ESolRPG : ESolArm // 적 대전차 보병 스탯
    {
        public override void AttackPlayer(Player player)
        {
            int SolRPGAttackValue = 60; // 대전차 보병 공격력
            int SolRPGValue = 10;
            System.Console.WriteLine("");

        }

    }






}
