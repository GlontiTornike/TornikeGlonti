using Homework5;
using System.Reflection;

Book book = new Book("Vefxistyaosani", "Shota Rustaveli", 1150);
Book book1 = new Book("Ana karenina", "Lev tolstoy", 1878);
Book book2 = new Book("jane Eary", "charlotte bronte", 1847);
Book book3 = new Book("igi", "Jemal Karchkhadze", 1977);




Library library = new Library([book, book1, book2, book3]);//count ar icvleba axali elementis damatebis dros

library.AddBook(book3);//1.3.3
library.RemoveBook(book1);//1.3.4


List<Book> foundBooks = library.FindBooks("igi");//1.3.5
foreach(var foundBook in foundBooks)
{
    Console.WriteLine(foundBook.GetBook());
}

//List<Book> allBooks = library.PrintBooks();//1.3.1 

//foreach (var item in allBooks)
//{
//    Console.WriteLine(item.GetBook());
//}



//Console.WriteLine("There're " + library.CountBooks() + " Books in Library");//1.3.2










//Task 2.0



//using Homework5;

//Console.Write("Enter a first Number: ");


//int first = int.Parse(Console.ReadLine());

//Console.Write("Enter a second Number: ");

//int second = int.Parse(Console.ReadLine());

//int jami = Calculator.Add(first, second);
//int skhvaoba = Calculator.Subtract(first, second);
//int namravli = Calculator.Multiply(first, second);
//double ganayofi = Calculator.Divide(first, second);

//Console.WriteLine("Sum = "+jami);
//Console.WriteLine("Subtract = " +skhvaoba);
//Console.WriteLine("Multiply = "+namravli);
//Console.WriteLine("Divide = "+ganayofi);



