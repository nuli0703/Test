using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = System.Console.ReadLine();
            int s1Number = Convert.ToInt32(s1);

            //string s2 = System.Console.ReadLine();
            //int s2Number = Convert.ToInt32(s2);
            //{
            //    int newInt = PlusTwoParam(s1Number, s2Number);
            //    System.Console.WriteLine(newInt);
            //}

            PlusTwoParam9(s1Number);
        }
        private static void PlusTwoParam9(int s1Number)
        {
            int numberlimit = s1Number;
            while (numberlimit > 0)
            {
                System.Console.WriteLine("Hi");

                numberlimit--;
            }
        }




        //string s3 = System.Console.ReadLine();
        //if (s3 == "+")
        //{
        //    int newInt2 = PlusTwoParam2(s1Number, s2Number);
        //    System.Console.WriteLine(newInt2);
        //}
        //else if (s3 == "-")
        //{
        //    int newInt3 = PlusTwoParam3(s1Number, s2Number);
        //    System.Console.WriteLine(newInt3);
        //}
        //else if (s3 == "*")
        //{
        //    int newInt4 = PlusTwoParam4(s1Number, s2Number);
        //    System.Console.WriteLine(newInt4);
        //}

        //else if (s3 == "%")
        //{
        //    int newInt5 = PlusTwoParam5(s1Number, s2Number);
        //    System.Console.WriteLine(newInt5);
        //}









    }
    }
   
