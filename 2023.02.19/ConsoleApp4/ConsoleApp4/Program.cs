using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            interfaceTestClassFirst interfaceFirst = new InterfaceTestClassFirst();
            interfaceFirst.TestInterfaceMethod();

            interfaceTestClassSecond interfaceSecond = new InterfaceTestClassSecond();
            interfaceFirst.TestInterfaceMethod();
        }
    }
    interface IInterfaceTest
    {
        void TestInterfaceMethod();


    }
    class InterfaceTestClassFirst : IInterfaceTest
    {
        public void TestInterfaceMethod()
        {
            System.Console.WriteLine("Hi");
        }
    }
    class InterfaceTestClassSecond : IInterfaceTest
    {
        public void TestInterfaceMethod()
        {
            System.Console.WriteLine("Hi");
        }
    }
}
