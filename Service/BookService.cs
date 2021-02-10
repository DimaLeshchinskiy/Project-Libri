using ProjectLibri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLibri.Service
{
    public class BookService
    {
        public List<Book> getAll()
        {
            List<Book> books = new List<Book>();

            for (int i = 0; i < 10; i++)
            {
                Book book = new Book();
                book.name = "Name" + i;
                book.id = "id" + i;
                books.Add(book);
            }

            return books;
        }

        public Book getOne()
        {
            Book book = new Book();
            book.name = "Name";
            book.id = "id";

            return book;
        }
    }
}
