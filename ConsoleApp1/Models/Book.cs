using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Book : BaseEntity
    {
        public string Name;
        public string Author;
        public int PageCount;
    }
}