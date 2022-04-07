using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Part2.Models
{
//    Book class (IEntity-ni implement edəcək)
//- Name
//- AuthorName
//- PageCount
//- IsDeleted - book obyektinin silinib silinmədiyini göstərən bir statusdur true/false olur default olaraq false olur yəni silinməmiş
//- ShowInfo()
    internal class Book:IEntity
    {


        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        private bool _isdeleted;
        public bool IsDeleted  
        { 
            get 
            { 
                return _isdeleted; 
            } 
            set 
            {
                value = false;
                _isdeleted = value; 
            }
        }
        public Book(string name, string authorname, int pagecount,bool isdeleted) //ps: Name, authorName, pageCount olmadan book obyekti yaratmaq olmaz
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            IsDeleted = isdeleted;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"");
        }
    }
}
