using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //task 2
    public static class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                return double.NaN;
            }
            return x / y;
        }

    }
    //task 1
    public class Book //1.1
    {
        // properties,rac ekutvnis am klass
        private string Title { get; set; }
        private string Author { get; set; }
        private int Year { get; set; }

        // constructor, rac kutvnilebebs anichebs mnishvnelobebs
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        //method, romlis mixedvitav vqnit sasurvel functias
        public string GetBook() { return Title + " " + Author + " " + Year; }
        public string GetTitle() { return Title; }
    }

    //task 1.3
    public class Library //1.2
    {

        //properties
        private List<Book> Books { get; set; }
        private int Count { get; set; }

        //CONSTRUCTOR

        public Library(List<Book> books)
        {
            Books = books;
            Count = Books.Count;
        }

        //method
        public List<Book> PrintBooks()
        {
            return Books;
        }

        public int CountBooks()
        {
            return Count;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public List<Book> FindBooks(string title)
        {

            return Books.FindAll(book =>book.GetTitle() == title);
            
        }
    }

}
