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
            // 9.서점 클래스에 제목, 지은이, 출판사를 입력받아 책 데이터를 쌓는다
            // 특정 키를 입력받을때 까지 지속되며, 특정 키 입력을 받으면
            // 제목을 입력받고 제목에 맞는 지은이, 출판사를 순서대로 출력해준다.

            Library library = new Library();

            int countBookNumber = 0;
            do
            {
                library.InputBooksData(countBookNumber);
                countBookNumber++;


            } while (library.AskKeepPutData());

            library.SearchTitle();

        }
    }
    class Book
    {
        public string title;
        public string writer;
        public string publisher;
    }
    class Library
    {
        Book[] books = new Book[99];

        public void InputBooksData(int BookCount)
        {
            books[BookCount] = new Book();

            System.Console.Write("제목 : ");
            books[BookCount].title = System.Console.ReadLine();

            System.Console.Write("지은이 : ");
            books[BookCount].writer = System.Console.ReadLine();

            System.Console.Write("출판사 : ");
            books[BookCount].publisher = System.Console.ReadLine();

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
        public void SearchTitle()
        {
            System.Console.Write("찾고싶은 제목 입력 : ");
            string userAnser = System.Console.ReadLine();

            for (int indexNum = 0; indexNum < books.Count(); indexNum++)
            {
                if (books[indexNum] == null)
                {
                    System.Console.WriteLine("못찾았습니다.");
                    break;
                }

                else if (books[indexNum].title == userAnser)
                {
                    System.Console.WriteLine($"제목 : {books[indexNum].title}");
                    System.Console.WriteLine($"지은이 : {books[indexNum].writer}");
                    System.Console.WriteLine($"출판사 : {books[indexNum].publisher}");
                    break;
                }


            }

        }
    }
}
