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
            Classes myNewClass = new Classes();
            myNewClass.WriteSchoolInfo("상원초등학교");
        }
    }
    class School
    {
        protected string SchoolName;
        private string TeacherName;
        protected void WriteSchoolName()
        {
            System.Console.WriteLine($"학교 이름 : {SchoolName}");
        }
    }
    class Classes : School
    {
        private string ClassName = "3반";
        public void WriteSchoolInfo(string _schoolName)
        {
            SchoolName = _schoolName;

            WriteSchoolName();
            System.Console.WriteLine($"내 반은 {ClassName}");

        }
    }
}
