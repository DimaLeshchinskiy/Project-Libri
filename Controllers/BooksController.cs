using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectLibri.Models;
using ProjectLibri.Service;

namespace ProjectLibri.Controllers
{
    public class BooksController : Controller
    {
        public JsonResult All()
        {
            BookService bookService = new BookService();
            List<Book> books = bookService.getAll();

            return Json(books);
        }

        public JsonResult One(String newId)
        {
            BookService bookService = new BookService();
            Book book = bookService.getOne();
            book.id = newId;

            return Json(book);
        }

        public JsonResult Index()
        {
            return All();
        }

    }
}
