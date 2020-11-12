using System;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("The Two Towers", 415);
            Console.ReadKey();
        }
    }
    class Book
    {
        public string title;
        private int pages;
        public Book(string ttl, int pgs)
        {
            title = ttl;
            pages = pgs;
            Console.WriteLine(title + " has " + pages + " pages");
        }
    }
}
     