using System;
using System.Collections.Generic;
using System.Text;

namespace P02_Book_Shop
{
    public class Book
    {
        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (char.IsDigit(value.Split(" ")[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }

        }
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder bookStringer = new StringBuilder();
            bookStringer.AppendLine($"Type: {this.GetType().Name}");
            bookStringer.AppendLine($"Title: {this.Title}");
            bookStringer.AppendLine($"Author: {this.Author}");
            bookStringer.AppendLine($"Price: {this.Price:F2}");
            return bookStringer.ToString().TrimEnd();
        }

        private string author;
        private string title;
        private decimal price;
    }
}
