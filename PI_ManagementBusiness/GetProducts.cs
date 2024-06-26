using PI_ManagamentData;
using ProductInventoryManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ManagementServices
{
    public class GetProducts
    {
        public List<CrochetProducts> GetAllProducts()//private turned public
        {
            ProductData productData = new ProductData();

            return productData.GetCrochetProducts();

        }

        public List<CrochetProducts> GetProductsAvailability (string availability)
        {
            List<CrochetProducts> productAvailable = new List<CrochetProducts>();

            foreach (var available in GetAllProducts())
            {
                if (available.availability == availability )
                {
                    productAvailable.Add(available);
                }
            }

            return productAvailable;
        }

        public CrochetProducts GetCrochetProducts (string name, string ID)
        {
            CrochetProducts foundProduct = new CrochetProducts();

            foreach (var products in GetAllProducts())
            {
                if (products.name == name && products.ID == ID)
                {
                    foundProduct = products;
                }
            }

            return foundProduct;
        }

        public CrochetProducts GetCrochetProducts (string name)
        {
            CrochetProducts foundProduct = new CrochetProducts();

            foreach (var products in GetAllProducts())
            {
                if (products.name == name)
                {
                    foundProduct = products;
                }
            }

            return foundProduct;
        }
    }
}
