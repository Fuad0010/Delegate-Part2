using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Part2.Models
{
    internal class Library:IEntity
    {
        public int BookLimit { get; set; }
        private int _books;
        List<Book> Books = new List<Book>();



    }
}
