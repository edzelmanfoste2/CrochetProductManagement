using PI_ManagamentData;
using PI_ManagementServices;
using ProductInventoryManagementModel;

namespace PI_ManagementServices
{
    public class ProductsServices
    {
        ProductCheckerValidate validationProduct = new ProductCheckerValidate();
        ProductData productData = new ProductData();

        public bool CreateProducts(CrochetProducts product)
        {
            bool result = false;

            if (validationProduct.CheckIfProductExists(product.name))
            {
                result = productData.AddProducts(product) > 0;
            }

            return result;
        }

        public bool CreateProducts(string ID, string name, string productType, string availability, string description, string category, string material, string size)
        {
            CrochetProducts Products = new CrochetProducts { 
                ID = ID, 
                name = name, 
                productType = productType , 
                availability = availability, 
                description = description, 
                category = category, 
                material = material, 
                size = size
            };

            return CreateProducts(Products);
        }

        public bool UpdateProducts(CrochetProducts products)
        {
            bool result = false;

            if (validationProduct.CheckIfProductExists(products.name))
            {
                result = productData.UpdateProducts(products) > 0;
            }

            return result;
        }

        public bool UpdateProducts(string ID, string name, string productType, string availability, string description, string category, string material, string size)
        {
            CrochetProducts products = new CrochetProducts {
                ID = ID,
                name = name,
                productType = productType,
                availability = availability,
                description = description,
                category = category,
                material = material,
                size = size
            };

            return UpdateProducts(products);
        }

        public bool DeleteProducts(CrochetProducts products)
        {
            bool result = false;

            if (validationProduct.CheckIfProductExists(products.name))
            {
                result = productData.DeleteProducts(products) > 0;
            }

            return result;
        }
    }
}
