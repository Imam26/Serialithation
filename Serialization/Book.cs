using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    [YearLimit(1995)]
    class Book
    {
        public string Name { set; get; }
        public double Price { set; get; }
        public string Author { set; get; }
        public int Year { get; set; }

        public Book(string name, double price, string author, int year)
        {
            Name = name;
            Price = price;
            Author = author;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Price: {0}", Price );
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Year: {0}", Year);
        }
    }
}
