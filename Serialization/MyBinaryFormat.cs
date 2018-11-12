using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    class MyBinaryFormat
    {
        private BinaryFormatter formatter = new BinaryFormatter();

        public void Serialize(List<Book> books, FileStream fStream)
        {        
            object[] attributes = typeof(Book).GetCustomAttributes(false);

            int limitYear = 0;

            foreach(object attribute in attributes)
            {
                if(attribute.GetType() == typeof(YearLimit)){
                    YearLimit year = (YearLimit)attribute;
                    limitYear = year.LimitYear;
                }
            }

            List<Book> newBooks = new List<Book>();

            foreach(Book book in books)
            {
                if (book.Year > limitYear)
                {
                    newBooks.Add(book);
                }
            }

            formatter.Serialize(fStream, newBooks);       
        }
    }
}
