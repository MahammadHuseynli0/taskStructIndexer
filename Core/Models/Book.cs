using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        private static int _no { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }



        public Book(string name, string authorName, int pageCount)
        {
            _no++;
            No = _no;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
        public override string ToString()
        {
            return $" No: {No} Name: {Name} AuthorName: {AuthorName} PageCount: {PageCount}";
        }
    }
}
