namespace OefenOpdracht5;

public class Catalogus
{
        
        private static   Catalogus? _instance;

        public static Catalogus GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Catalogus();
                _instance.Initialize();
            }

            return _instance;
        }
    
        private List<Product> products = new List<Product>();

        public void Initialize()
        {
            products.Add(new Product("Appel"));
            products.Add(new Product("Peer"));
        }

        public void PrintCatalogus()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public void AddProduct(String name)
        {
            products.Add(new Product(name));
        }
}