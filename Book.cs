using System;

namespace Inheritance
{

    class Book : Publication
    {

        private string _author;

        public Book(string title, string author, decimal price, int pageCount) :
            base(title, price, pageCount)
        {
            _author = author;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public override string GetDescription()
        {
            return $"{Title} by {Author}, {PageCount} pages";
        }
    }
}