namespace ADVC_02
{
    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> factory)
        {
            List<Product> Listproducts = new List<Product>();

            foreach (Product product in products)
            {
                if (factory(product))
                    Listproducts.Add(product);
            }
            return Listproducts;
        }

        public static void shortReport(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }

        public static void detailedReport(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}");
            }
        }

        public static List<string> TransformProducts(List<Product> products, Func<Product, string> selector)
        {
            List<string> Listproducts = new List<string>();

            foreach (Product product in products)
            { 
                    Listproducts.Add((string)selector(product));
            }
            return Listproducts;
        }

    }
}
