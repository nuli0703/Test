using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            
            Zombie zombie = new Zombie();
            Ghoul ghoul = new Ghoul();

            
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

    abstract class DarkMonster
    {
        int attackValue = 10; //데미지

        public abstract void AttackPlayer(Player player); // abstract

    }

    class Zombie : DarkMonster
    {
        public override void AttackPlayer(Player player)
        {
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
