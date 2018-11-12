using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("Книга 1", 200.5, "Автор 1", 2000),
                new Book("Книга 2", 300.234, "Автор 2", 1994),
                new Book("Книга 3", 100.2, "Автор 3", 1980),
                new Book("Книга 4", 50.12, "Автор 4", 2011),
                new Book("Книга 5", 350.10, "Автор 5", 1999)
            };

            //Класс MyBinryFormat сериализует список согласно пользовательского аттрибута YearLimit(1995)
            //то есть сериализуются только те книги где свойство Year > 1995
            MyBinaryFormat myFormatter = new MyBinaryFormat();

            using (FileStream fStream = new FileStream("BinaryFile.dat", FileMode.Create))
            {
                myFormatter.Serialize(books, fStream);
            }

            List<Book> newBooks = new List<Book>();

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fStream = new FileStream("BinaryFile.dat", FileMode.Open))
            {
                newBooks = (List<Book>)formatter.Deserialize(fStream);

                foreach(Book book in newBooks)
                {
                    book.Show();
                }
            }
        }
    }
}
