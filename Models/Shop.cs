namespace incerc.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string ShopName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
