using mvc_unit_books.Models;

namespace mvc_unit_books.Repository
{
    public class BooksRepository
    {

		private static List<Book> book_list;
		public BooksRepository()
        {
			if(book_list == null)
            {
				book_list = new List<Book>();
            }
        }

		public List<string> GetGenres()
		{
			return new List<string>()
			{
				"Fantastika",
				"Triler",
				"Komedija",
				"Autobiografija"
			};
		}

		public void CreateBook(Book new_book)
        {
			book_list.Add(new_book);
        }

	}
}
