using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Library
    {
        public Book[] Books = new Book[] { };


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }


        public Book[] FindAllBooksByName(string findname)
        {
            Book[] FindBooks = new Book[] { };

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == findname)
                {
                    Array.Resize(ref FindBooks, FindBooks.Length + 1);
                    FindBooks[FindBooks.Length - 1] = Books[i];
                }
            }
            return FindBooks;

        }

        public Book[] RemoveAllBooksByName(string name)
        {
            Book[] RemoveBooks = new Book[] { };

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name! == name)
                {
                    Array.Resize(ref RemoveBooks, RemoveBooks.Length + 1);
                    RemoveBooks[RemoveBooks.Length - 1] = Books[i];
                }
            }
            return RemoveBooks;
        }

        public Book[] SearchBook(string value)
        {

            Book[] SearchBooks = new Book[] { };
            int inttypeValue;
            if (int.TryParse(value, out inttypeValue))
            {

                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].PageCount == inttypeValue)
                    {

                        {
                            Array.Resize(ref SearchBooks, SearchBooks.Length + 1);
                            SearchBooks[SearchBooks.Length - 1] = Books[i];
                        }
                    }
                }
                return SearchBooks;
            }
            else
            {

                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].Name == value || Books[i].AuthorName == value)
                    {
                        Array.Resize(ref SearchBooks, SearchBooks.Length + 1);
                        SearchBooks[SearchBooks.Length - 1] = Books[i];
                    }
                }
                return SearchBooks;
            }
        }
    }
}


        
    

