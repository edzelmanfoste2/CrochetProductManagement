using ProductInventoryManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ManagamentData
{
    public class ProductData
    {
        List<CrochetProducts> products;
        SQLDbData sqlData;
        public ProductData()
        {
            products = new List<CrochetProducts>();
            sqlData = new SQLDbData();

            //UserFactory _userFactory = new UserFactory();
            //users = _userFactory.GetDummyUsers();
        }

        public List<CrochetProducts> GetCrochetProducts()
        {
            products = sqlData.GetProducts();
            return products;
        }

        public int AddProducts(CrochetProducts products)
        {
            return sqlData.AddProducts(products.ID, products.name, products.productType, products.availability, products.description, products.category, products.material, products.size);
        }

        public int UpdateProducts(CrochetProducts products)
        {
            return sqlData.UpdateProducts(products.ID, products.name, products.productType, products.availability, products.description, products.category, products.material, products.size);
        }

        public int DeleteProducts(CrochetProducts products)
        {
            return sqlData.DeleteProducts(products.name);
        }
    }
}
