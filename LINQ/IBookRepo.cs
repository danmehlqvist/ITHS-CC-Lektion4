﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public interface IBookRepo
    {
        IEnumerable<Book> Books { get; set; }
    }
}
