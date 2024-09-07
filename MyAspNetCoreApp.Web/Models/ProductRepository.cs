namespace MyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Product 1", Price = 100, Stock = 10 },
            new Product { Id = 2, Name = "Product 2", Price = 200, Stock = 20 },
            new Product { Id = 3, Name = "Product 3", Price = 300, Stock = 30 },
        };

        public List<Product> GetAll() => _products;

        public void Add(Product newProduct) => _products.Add(newProduct);

        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == id);

            if(hasProduct == null)
            {
                throw new InvalidOperationException($"Product withe the id ({id}) is not found");
            }

            _products.Remove(hasProduct);
        }

        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(p => p.Id == updateProduct.Id);

            if(hasProduct == null)
            {
                throw new InvalidOperationException($"Product withe the id ({updateProduct.Id}) is not found");
            }

            hasProduct.Name = updateProduct.Name;
            hasProduct.Price = updateProduct.Price;
            hasProduct.Stock = updateProduct.Stock;

            var index = _products.FindIndex(p => p.Id == updateProduct.Id);
            _products[index] = hasProduct;
        }
    }
}
