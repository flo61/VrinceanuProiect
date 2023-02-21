namespace incerc.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string GenreName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
