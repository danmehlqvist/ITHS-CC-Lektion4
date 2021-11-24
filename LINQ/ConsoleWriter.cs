using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    /// <summary>
    /// Generic class that writes objects to Console
    /// </summary>
    public class ConsoleWriter<T> : IDataWriter<T>
    {
        public void Write(IEnumerable<T> t)
        {
            foreach (T item in t)
            {
                Write(item);
            }
        }

        public void Write(T t)
        {
            Console.WriteLine(t);
        }

        public void NewLine()
        {
            Console.WriteLine();
        }
    }
}
