using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime FirstPublished { get; set; }
        public int Price { get; set; }

        public Book(int iD, string name, DateTime firstPublished, int price)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            FirstPublished = firstPublished;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, First published: {FirstPublished.ToShortDateString()}, Price: {Price}";
        }
    }
}
