using Product.Models;

namespace Product.Services
{
    public class ItemService
    {
        private readonly static IEnumerable<Item> _pizzas = new
            List<Item>()
        {
            new Item
            {
                Name = "Laptops",
                Image = "lappy.jpg",
                Price = 1025.1
            },
            new Item
            {
                Name = "Telivisions",
                Image = "tv.jpg",
                Price = 766.5
            },
            new Item
            {
                Name = "Watches",
                Image = "watches.jpg",
                Price = 199.5
            },
            new Item
            {
                Name = "Mobiles",
                Image = "mobile.jpg",
                Price = 999.45
            },
             new Item
            {
                Name = "Earpods",
                Image = "ep.jpg",
                Price = 295.1
            },
            new Item
            {
                Name = "Washing Machine",
                Image = "whm.jpg",
                Price = 652.5
            },
            new Item
            {
                Name = "Refrigirators",
                Image = "fdg.png",
                Price = 899.5
            },
            new Item
            {
                Name = "Sound Bars",
                Image = "sb.jpg",
                Price = 499.45
            }
        };
        public IEnumerable<Item> GetallPizzas() => _pizzas;
        public IEnumerable<Item> GetPopularPizzas(int count = 8) => _pizzas.OrderBy(p=> Guid.NewGuid())
            .Take(count);

        public IEnumerable<Item> SearchPizzas(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        


        
    }
}
      

        



    

    


