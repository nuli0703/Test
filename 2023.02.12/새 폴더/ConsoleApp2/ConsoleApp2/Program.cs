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
            //3. 학생 클래스를 만들어서 for문으로 학생 여럿을 입력받는다
            Student[] students = new Student[2];

            for (int i = 0; i < 2; i++)
            {
                students[i] = new Student();
                students[i].InputStudentInfoData();
            }
        }
        

            class Student
        {
            public string name;
            public int age;

            public void WritelineStudentInfo()
            {
                System.Console.WriteLine($"학생의 이름은 {name}");
                System.Console.WriteLine($"학생의 이름은 {age}");

            }
            public void InputStudentInfoData()
            {
                System.Console.WriteLine("학생의 이름은");
                name = System.Console.ReadLine();
                System.Console.WriteLine("학생의 나이는");
                age = Convert.ToInt32(System.Console.ReadLine());

                WritelineStudentInfo();

            }
        }


    
    }
}
