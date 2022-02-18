using System;

namespace Inheritance
{

    class Publication
    {

        private string _title;
        private decimal _price;

        public Publication(string title, decimal price, int pages)
        {
            _title = title;
            _price = price;
            PageCount = pages;
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Jy kan nie 'n lee title verskaf nie");
                }
                _title = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public int PageCount
        {
            get; set;
        }

        public virtual string GetDescription()
        {
            return $"{Title}, {PageCount} pages";
        }
    }
}