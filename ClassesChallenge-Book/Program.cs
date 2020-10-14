using System;
using System.Dynamic;

namespace ClassesChallenge_Book
{
    public class Book
    {
        public string bookName;
        public string autorName;
        public double bookPrice;

        public void logBook()
        {
            Console.WriteLine(bookName +" by " + autorName + " the price is: " + bookPrice);
        }

    }

    class Program
    {
        static void Main(string[]args)
        {
            Book book1 = new Book();
            book1.bookName = "stormlight Archives: The Way of Kings ";
            book1.autorName = "Brandon Sanderson ";
            book1.bookPrice = 9.99;

            book1.logBook();
        }
    }
}