using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12.학생 클래스를 만들고
            // Classes란 클래스를 만들어서
            //학생들의 이름과 반을 입력받아 배열로 저장한다.

            // Classes 클래스에서 숫자를 입력하면
            // 입력숫자와 같은 반에 들어간 모든 학생을 출력해준다. (이름만)

            Classes student = new Classes();

            int countStudentNumber = 0;
            do
            {
                student.InputStudentDataa(countStudentNumber);
                countStudentNumber++;

            } while (student.AskKeepPutData());

            student.searchStudent();


        }
    }
    class Classes
    {
        public string StudentName;
        public string StudentRoom;
        public int SstudentRoom;
        public int userAnserr;


        Classes[] students = new Classes[99];

        public void InputStudentDataa(int ClassesCount)
        {
            students[ClassesCount] = new Classes();

            System.Console.Write("학생 이름 : ");
            students[ClassesCount].StudentName = System.Console.ReadLine();

            System.Console.Write("학생 반 : ");
            students[ClassesCount].StudentRoom = System.Console.ReadLine();
            SstudentRoom = Convert.ToInt32(StudentRoom);

            System.Console.WriteLine("------------------");
        }
        public bool AskKeepPutData()
        {
            System.Console.Write("계속 입력할까요? (y/n) : ");
            string userAnser = System.Console.ReadLine();

            if (userAnser == "Y" || userAnser == "y")
            {
                return true;
            }
            else
            {
                return false;

            }
        }
            public void searchStudent()
            {

                System.Console.Write("찾고자 하는 반을 입력해주세요.");
                string userAnser = System.Console.ReadLine();
                userAnserr = Convert.ToInt32(userAnser);

                for (int indexNum = 0; indexNum < students.Count(); indexNum++)
                {
                    if (students[indexNum] == null)
                    {
                        System.Console.WriteLine("해당하는 정보가 없습니다.");
                        break;
                    }
                    else if (students[indexNum].StudentRoom == userAnser)
                    {
                        System.Console.WriteLine($"학생이름 : {students[indexNum].StudentName}");
                        
                    }


                }


            }


        }



    }
