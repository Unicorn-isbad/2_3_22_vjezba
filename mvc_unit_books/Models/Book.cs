using System.ComponentModel.DataAnnotations;

namespace mvc_unit_books.Models
{
    public class Book
    {
		public int Id { get; set; }

		[Display(Name = "Naslov knjige")]
		public string Title { get; set; }

		[Display(Name = "Žanr knjige")]
		public string Genre { get; set; }

		[Display(Name = "Cijena knjige")]
		[DataType(DataType.Currency)]
		[Range(1, 1000)]
		public decimal Price { get; set; }

		[Display(Name = "Datum objave")]
		[DataType(DataType.Date)]
		public DateTime PublishDate { get; set; }
	}
}
