using System;

namespace Inheritance
{

    class Magazine : Publication
    {

        private string _publisher;

        public Magazine(string title, string publisher, decimal price, int pages)
            : base(title, price, pages)
        {
            _publisher = publisher;
        }

    }
}