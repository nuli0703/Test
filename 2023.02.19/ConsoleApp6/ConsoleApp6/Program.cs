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
            Player player = new Player();

            DarkMonster darkmonster = new DarkMonster();
            Zombie zombie = new Zombie();
            Ghoul ghoul = new Ghoul();

            darkmonster.AttackPlayer(player);
            System.Console.WriteLine();

            zombie.AttackPlayer(player);
            System.Console.WriteLine();

            ghoul.AttackPlayer(player);
            System.Console.WriteLine();



        }
    }
    class Player
    {
        int hp = 100;
        public void HitFromMonster(int AttackValue)
        {
            hp = hp - AttackValue;
            System.Console.WriteLine($"Player : I'm Hit! my Hp is {hp}");

        }

    }

    class DarkMonster
    {
        int attackValue = 10; //데미지

        public virtual void AttackPlayer(Player player) // 변경이 가능 할 수 있다는 점
        {
            System.Console.WriteLine("Monster : Player Attack");
            player.HitFromMonster(attackValue);


        }
      
    }
    class Zombie : DarkMonster
    {
        public override void AttackPlayer(Player player)
        {
            base.AttackPlayer(player);
            System.Console.WriteLine("Monster : Player Bleeding");

        }

    }
    class Ghoul : DarkMonster
    {
        public override void AttackPlayer(Player player)
        {
            System.Console.WriteLine("Monster(Ghoul) : Player Curse !");
        }


    }

}
