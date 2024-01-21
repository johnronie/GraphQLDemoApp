public class Query
{
    public Product GetProduct() =>
        new Product
        {
            Name = "Laptop",
            Description = "Lenovo Laptop",
            Price = 1299.99m,
            Category = "PC",
            Manufacturer = new Manufacturer
            {
                Name = "Lenovo China",
                Location = "China"
            }
        };

    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                Name = "Laptop",
                Description = "Lenovo Laptop",
                Price = 1299.99m,
                Category = "PC",
                Manufacturer = new Manufacturer
                {
                    Name = "Lenovo China",
                    Location = "China"
                }
            },
            new Product
            {
                Name = "Mouse",
                Description = "Lofitech Mouse",
                Price = 99.99m,
                Category = "PC",
                Manufacturer = new Manufacturer
                {
                    Name = "Logitech China",
                    Location = "China"
                }
            },
            new Product
            {
                Name = "Keyboard",
                Description = "Logitech Keyboard",
                Price = 1299.99m,
                Category = "PC",
                Manufacturer = new Manufacturer
                {
                    Name = "Logitech China",
                    Location = "China"
                }
            }
        };
        return products;
    }
}