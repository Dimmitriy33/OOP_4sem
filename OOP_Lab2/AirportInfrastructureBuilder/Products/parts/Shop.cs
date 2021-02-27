namespace OOP_Lab2
{
    public class Shop
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Product() { }
            public Product(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }
        private Product water = new Product("water", 1.5);
        private Product coffee = new Product("coffee", 2.5);
        private Product chocolate = new Product("chocolate", 2.2);
        public Shop() { }

        public Product buyProduct(string product)
        {
            switch (product)
            {
                case "water":
                    return water;
                case "coffee":
                    return coffee;
                case "chocolate":
                    return chocolate;
                default:
                    return new Product("unknown", 0);
            }
        }


    }
}
