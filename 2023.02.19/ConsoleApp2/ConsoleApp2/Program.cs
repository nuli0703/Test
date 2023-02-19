using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomInt = rand.Next(0, 10);
            Console.WriteLine("0~10사이 랜덤 : " + randomInt);

        }
    }
    public enum thePlayerState
    {
        idle,
        walk,
        run
    }
    class enu
    {
        static void Main1(string[] args)
        {

            thePlayerState myState = thePlayerState.idle;
            switch (myState)
            {
                case thePlayerState.idle:
                    System.Console.WriteLine("I'm idle");
                    break;
                case thePlayerState.walk:
                    System.Console.WriteLine("I'm walking");
                    break;
                case thePlayerState.run:
                    System.Console.WriteLine("I'm running");
                    break;


            }

        }
    }
}

    