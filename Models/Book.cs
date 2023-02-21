using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace incerc.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? GenreID { get; set; }
        public Genre? Genre { get; set; }
        public int? ShopID { get; set; }
        public Shop? Shop { get; set; }
    }
}
