using ProductInventoryManagementModel;
using PI_ManagementServices;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<CrochetProducts> productsDB = SQLDbData.GetProducts();

            GetProducts getProducts = new GetProducts();

            var avail = getProducts.GetAllProducts();

            foreach (var product in avail)
            {
                Console.WriteLine(product.ID);
                Console.WriteLine(product.name);
                Console.WriteLine(product.productType);
                Console.WriteLine(product.availability);
                Console.WriteLine(product.description);
                Console.WriteLine(product.category);
                Console.WriteLine(product.material);
                Console.WriteLine(product.size);
            }
        }
    }
}
