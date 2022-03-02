using mvc_unit_books.Models;
using mvc_unit_books.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using mvc_unit_books.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace mvc_unit_books.Tests
{
    public class BooksRepositoryTests
    {
        [Fact]
        public void BookRepository_GetGenres_ValidIfNotNull()
        {
            Assert.True((new BooksRepository()).GetGenres().Count > 0);
        }
        [Theory, ClassData(typeof(TestData))]
        public void BookRepository_CreateBook_ValidIfAdds(Book book)
        {
            BooksRepository.CreateBook(book);

            var result = (new HomeController()).Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Book>>(viewResult.ViewData.Model);

            Assert.True(model.Count > 0);
        }
    }
}
