using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class BookDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Book som DTO! ID: {ID}, Name: {Name}";
        }

    }

}
