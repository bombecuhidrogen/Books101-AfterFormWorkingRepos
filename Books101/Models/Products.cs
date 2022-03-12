namespace Books101.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PriceInLei { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Product()
        {

        }
    }
}
