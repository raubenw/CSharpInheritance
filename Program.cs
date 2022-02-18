using System;

namespace Inheritance
{

    public class Program
    {

        public static void Main(string[] args)
        {

            Book book = new Book("Oorlog en Vrede", "Jan Kees", 123.45m, 981);
            Magazine magazine = new Magazine("Coders R Us", "The Werner Times", 318.23m, 4011);

            // Testing assigning empty string to Title
            //book.Title = "";

            Console.WriteLine($"Book details: {book.GetDescription()}");
            Console.WriteLine($"Magazine details: {magazine.GetDescription()}");

        }
    }
}