using Microsoft.AspNetCore.Mvc;
using mvc_unit_books.Models;
using mvc_unit_books.Repository;

namespace mvc_unit_books.Controllers
{
    public class BooksController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book new_book)
        {
            BooksRepository.CreateBook(new_book);
            return RedirectToAction("Index", "Home");
        }
    }
}
