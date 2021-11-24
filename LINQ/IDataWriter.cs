using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal interface IDataWriter<T>
    {
        void Write(IEnumerable<T> t);
        void Write(T t);
        void NewLine();
    }
}
