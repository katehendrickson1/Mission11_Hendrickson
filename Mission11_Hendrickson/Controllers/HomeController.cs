using Microsoft.AspNetCore.Mvc;
using Mission11_Hendrickson.Models;
using Mission11_Hendrickson.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Hendrickson.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _book;
        public HomeController(IBookRepository temp)
        {
            _book = temp;
        }


        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var bookList = new BookListViewModel
            {
                Books = _book.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _book.Books.Count()

                }
            };


            return View(bookList); // how to load up data to index page
        }

    }

}

