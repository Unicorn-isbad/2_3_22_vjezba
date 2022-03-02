using mvc_unit_books.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_unit_books.Tests
{
    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Book() { Id = 1, Title = "Title 1", Genre = "Fantastika", Price = 100, PublishDate = DateTime.Now } };
            yield return new object[] { new Book() { Id = 1, Title = "Title 2", Genre = "Triler", Price = 200, PublishDate = DateTime.Now } };
            yield return new object[] { new Book() { Id = 1, Title = "Title 3", Genre = "Komedija", Price = 300, PublishDate = DateTime.Now } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
