using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class BookRepo:IBookRepo
    {
        public IEnumerable<Book> Books  { get; set; }

        public BookRepo()
        {
            Books = new List<Book>
            {
                new Book(1,"The Gargoyle",new DateTime(2008,1,1),100),
                new Book(2,"Clean Code: A Handbook Of Agile Software Craftsmanship",new DateTime(2008,8,18),200),
                new Book(3,"Network Security",new DateTime(2012,12,1),300),
                new Book(4,"ASP.NET Core 2.0",new DateTime(2010,6,10),400),
            };
        }
    }
}
