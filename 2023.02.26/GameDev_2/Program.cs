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
                    Searching.BaseInfoData3(player);
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
                default:
                    Console.WriteLine("1번부터 3번 중 명령을 골라주세요.");
                    Order.BaseInfoData2(player);
                    break;
            }
        }
    }

    public class Searching
    {
        public static void Fails() { } //수색 실패
        public static void Success() { } //적 발견

        public static void BaseInfoData3(Player player)
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 8);
            if (randInt == 0) //0인 경우 수색실패
            {
                Fails();
                Console.WriteLine("발견한 것이 없습니다.");
                Console.WriteLine("엔터를 누르시면 이전 메뉴로 복귀합니다.");
                Order.BaseInfoData2(player);
            }
            else // 적발견
            {
                Success();
                Console.WriteLine("적을 발견하였습니다.");
                int enemyType = rand.Next(1, 5);
                Enemy enemy = null;
                switch (enemyType)
                {
                    case 1:
                        enemy = new EBTR();
                        break;
                    case 2:
                        enemy = new ETank();
                        break;
                    case 3:
                        enemy = new ESolRifle();
                        break;
                    case 4:
                        enemy = new ESolRPG();
                        break;
                    default:
                        Console.WriteLine("적 생성 실패");
                        break;
                }
                if (enemy != null)
                {
                    Battle.BattleSC(player, enemy);
                }
                else
                {
                    Console.WriteLine("적이 생성되지 않았습니다.");
                }
            }
        }
    }
    public class Battle
    {
        public static void BattleSC(Player player, Enemy enemy)
        {
            Console.WriteLine("전투가 시작");
            Console.WriteLine();
            Console.WriteLine("플레이어 차량 체력: " + player.HP);
            Console.WriteLine("적 차량 체력: " + enemy.HP);

            while (player.HP > 0 && enemy.HP > 0)
            {
                Console.WriteLine();
                Console.WriteLine("==== 전투 시작 ====");
                Console.WriteLine("플레이어 차량 행동 선택");
                Console.WriteLine("1. 공격하기");
                Console.WriteLine("2. 방어하기");
                Console.WriteLine("3. 철갑탄 발사하기 (보유 탄약 수: " + player.APP + ")");
                Console.WriteLine("4. 퇴각하기");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: // 공격하기
                        Console.WriteLine("아군 차량이 적을 공격합니다!");
                        player.Attack(enemy);
                        break;

                    case 2: // 방어하기
                        Console.WriteLine("아군 차량이 방어 합니다!");
                        player.Avoid();
                        break;

                    case 3: // 철갑탄 발사하기
                        if (player.APP > 0)
                        {
                            Console.WriteLine("아군 차량이 철갑탄을 발사합니다!");
                            player.APP--;
                            player.Attack(enemy, 200);
                        }
                        else
                        {
                            Console.WriteLine("보유한 철갑탄이 없습니다!");
                        }
                        break;
                    case 4: // 도망가기
                        Console.WriteLine("즉시 퇴각갑니다!");
                        Menu.MenuInfoData1(player);
                        return;
                }

                Console.WriteLine();

                if (enemy.HP > 0)
                {
                    Console.WriteLine("적이 반격합니다!");
                    if (enemy is EBTR) ((EBTR)enemy).AttackPlayer(player);
                    else if (enemy is ETank) ((ETank)enemy).AttackPlayer(player);
                    else if (enemy is ESolRifle) ((ESolRifle)enemy).AttackPlayer(player);
                    else if (enemy is ESolRPG) ((ESolRPG)enemy).AttackPlayer(player);
                }

                Console.WriteLine();
                Console.WriteLine("==== 턴 종료 ====");
                Console.WriteLine("플레이어 차량 체력: " + player.HP);
                Console.WriteLine("적 차량 체력: " + enemy.HP);
            }

            Console.WriteLine();

            if (player.HP <= 0)
            {
                Console.WriteLine("아군 차량이 파괴되었습니다. 전투에 패배하였습니다.");
            }
            else if (enemy.HP <= 0)
            {
                Console.WriteLine("적 차량이 파괴되었습니다. 전투에 승리하였습니다!");
                Console.WriteLine("보상으로 1000원을 획득하였습니다.");
                Console.ReadLine();
                Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
                Console.ReadLine();
                Order.BaseInfoData2(player);
                player.Money += 1000;
            }

            Console.WriteLine("엔터를 누르시면 기지로 복귀합니다.");
            Console.ReadLine();
            Order.BaseInfoData2(player);
        }
    }
    class Enemy
    {
        public int HP { get; protected set; }
    }

    class EBTR : Enemy
    {
        public EBTR()
        {
            HP = 500;
        }

        public virtual void AttackPlayer(Player player)
        {
            int LightAttackValue = 100; // 적 장갑차 공격력
            System.Console.WriteLine("");
        }
    }

    class ETank : Enemy
    {
        public ETank()
        {
            HP = 800;
        }

        public virtual void AttackPlayer(Player player)
        {
            int HeavyAttackValue = 100; // 적 전차 공격력
            System.Console.WriteLine("");
        }
    }

    class ESolRifle : Enemy
    {
        public ESolRifle()
        {
            HP = 200;
        }

        public virtual void AttackPlayer(Player player)
        {
            int SolAttackValue = 30; // 적 일반 보병 공격력
            System.Console.WriteLine("");
        }
    }

    class ESolRPG : Enemy
    {
        public ESolRPG()
        {
            HP = 200;
        }

        public virtual void AttackPlayer(Player player)
        {
            int SolRPGAttackValue = 60; // 적 대전차 보병 공격력
            System.Console.WriteLine("");
        }
    }

    public class Player // 플레이어 차량 스탯
    {
        public int HP = 2000;
        public int Def = 80; // 방어력
        public int Att = 100; // 주포 공격력
        public int APP = 0; // 철갑탄 보유 수
        public int Ful = 120; // 연료
        public int Money = 0; // 보유금액

        public void DecreaseAPP()
        {
            APP--;
        }
    }
    public abstract class Entity
    {
        public int HP { get; protected set; }
        public int Def { get; protected set; }
        public int Att { get; protected set; }

        public virtual void Attack(Entity target, int damage)
        {
            int dealtDamage = damage - target.Def;
            if (dealtDamage < 0) dealtDamage = 0;
            target.HP -= dealtDamage;
            Console.WriteLine("적이 " + dealtDamage + "의 데미지를 입었습니다.");
        }

        public virtual void Attack(Entity target)
        {
            Attack(target, Att);
        }

        public virtual void Avoid()
        {
            Console.WriteLine("아군 차량이 방어를 준비합니다!");
        }

        public virtual void TakeDamage(int damage)
        {
            Console.WriteLine("아군 차량이 " + damage + "의 데미지를 입었습니다.");
            HP -= damage;
            if (HP <= 0)
            {
                Console.WriteLine("아군 차량이 파괴되었습니다.");
            }
        }
    }

    public class PPlayer : Entity
    {
        public PPlayer()
        {
            HP = 2000;
            Def = 80;
            Att = 100;
        }

        public override void Attack(Entity entity, int damage)
        {
            Console.WriteLine("아군 차량이 적을 공격합니다!");
            base.Attack(entity, damage);
        }








        // 적 스탯들


        

    }
}
