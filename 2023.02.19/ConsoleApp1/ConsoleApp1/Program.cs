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
            //1. 통장 클래스 제작
            //2. 본 통장 클래스에는 잔고(int)가 있음.
            //3. 입금 / 출금 / 이체 메소드를 보유하고 있다.

            //4. 통장 클래스를 가지고 2개의 인스턴스를 만든다(A통장/B통장)
            //5. 수중에 100만원을 가지고 있는 것으로 시작한다. (int)

            //6. Main에서 선택지를 띄운다. While문을 이용해서 특정 키가 들어올 때 까지 계속 반복한다.
            // 선택지는 1. 입금 2. 출금 3. 이체 3개가 있다.
            // 여기서 선택지는 항상 A통장 기준이다.

            //7. 입금을 선택하고 금액을 입력하면, 수중의 돈이 줄어들고 A통장은 금액이 추가된다.
            // A통장의 잔액이 출력된다.

            //8. 출금을 선택하고 금액을 입력하면, 수중의 돈이 늘어나고 A통장의 금액은 줄어든다.
            // A통장의 잔액이 출력된다.

            //9. 이체를 선택하고 금액을 입력하면, A통장의 금액이 줄어들고, B통장의 금액이 늘어난다.
            // A통장과 B통장의 잔액을 출력한다.
        {
            int myMoney = 100;


            Bank Abank = new Bank();
            Bank Bbank = new Bank();


            while(true)
            {
                System.Console.WriteLine("입력해주세요.");
                System.Console.WriteLine("1.입금");
                System.Console.WriteLine("2.출금");
                System.Console.WriteLine("3.이체");

                int SelectNumber = int.Parse(Console.ReadLine());
                switch(SelectNumber)
                {

                    //입금
                    case 1:
                        int PutMoneyCount = int.Parse(Console.ReadLine());
                        
                        Abank.PutMoney(PutMoneyCount);
                        myMoney = myMoney - PutMoneyCount;
                        System.Console.WriteLine($"잔액은 {myMoney}입니다");
                        Abank.PutMoney();
                        break;


                        //출금
                    case 2:
                        Abank.TakeMoney();

                        int PutMoneyCount2 = int.Parse(Console.ReadLine());

                        Abank.PutMoney(PutMoneyCount2);
                        myMoney = myMoney - PutMoneyCount2;
                        System.Console.WriteLine($"잔액은 {myMoney}입니다");
                        Abank.PutMoney2();
                        break;



                        break;


                        //이체
                    case 3:
                        Abank.SendMoney();
                        break;

                        int PutMoneyCount3 = int.Parse(Console.ReadLine());

                        Abank.PutMoney(PutMoneyCount3);
                        myMoney = myMoney - PutMoneyCount3;
                        

                        System.Console.WriteLine($"잔액은 {myMoney}입니다");
                        Abank.PutMoney();
                        break;





                    default:
                        System.Console.WriteLine("종료합니다");
                        return;
                        break;


                }

            }





        }


    }
    class Bank
    {
        public int BankMoney;

        public void PutMoney(int putMoney)
        {
            System.Console.WriteLine("입금을 진행합니다.");
            bankMoney = bankMoney + putMoney;
            System.Console.WriteLine($"Abank 잔액은 {BankMoney} 입니다.");

        }
        public void TakeMoney()(int )
        {
            System.Console.WriteLine("출금을 진행합니다.");
            bankMoney = bankMoney - putMoney;
            System.Console.WriteLine($"Abank 잔액은 {BankMoney} 입니다.");


        }
        public void SendMoney()
        {
            System.Console.WriteLine("이체를 진행합니다.");
            bankMoney = bankMoney - putMoney;
            System.Console.WriteLine($"Abank 잔액은 {BankMoney} 입니다.");

        }
        public class choose
        {
            public static void Main()
            {


            }


        }

    }
}
