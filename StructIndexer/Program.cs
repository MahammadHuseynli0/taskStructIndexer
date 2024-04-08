using System.Runtime.InteropServices;
using Core.Models;
namespace StructIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            Book book1 = new Book("Shuggie Bain", "Douglas Stuart", 430);
            Book book2 = new Book("White Noise", "Don DeLillo", 310);
            Book book3 = new Book("American Psycho", "Bret Easton Ellis", 399);
            Book book4 = new Book("War of the World", "H. G. Wells", 336);
            Book book5 = new Book("Frankenstein", "Mary Shelley", 280);


            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            for (int i = 0; i < library.FindAllBooksByName("American Psycho").Length; i++)
            {
                Console.WriteLine(library.FindAllBooksByName("American Psycho")[i].ToString());
            };



            library.RemoveAllBooksByName("Shuggie");



            for (int i = 0; i < library.SearchBook("336").Length; i++)
            {
                Console.WriteLine(library.SearchBook("336")[i].ToString());
            };

        }

    }
}
















