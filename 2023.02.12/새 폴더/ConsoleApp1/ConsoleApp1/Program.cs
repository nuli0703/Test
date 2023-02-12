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
            //1. 학생 클래스를 만들어서 학생 하나의 이름과 나이의 정보를 입력받는다 (Readline)
            //Student AStudent = new Student();
            //System.Console.WriteLine("학생의 이름을 적어주세요");
            //AStudent.name = System.Console.ReadLine();
            //System.Console.WriteLine("학생의 나이를 적어주세요");
            //AStudent.age = Convert.ToInt32(System.Console.ReadLine());

            //AStudent.WritelineStudentInfo();


            //2. 학생클래스를 만들어서 메소드로 학생 하나의 정보를 입력받는다.
            
            Student AStudent = new Student();
            AStudent.InputStudentInfoData();

            //3. 학생 클래스를 만들어서 for 문으로 학생 여럿을 입력받는다

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
