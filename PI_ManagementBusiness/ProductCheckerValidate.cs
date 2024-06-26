using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_ManagementServices
{
    public class ProductCheckerValidate
    {
        GetProducts getProducts = new GetProducts();

        public bool CheckIfProductExists(string name)
        {
            bool result = getProducts.GetCrochetProducts(name) != null;
            return result;
        }

        public bool CheckProductExistence(string name, string ID) //with Unique Identifier (Product ID)
        {
            bool result = getProducts.GetCrochetProducts(name, ID) != null;
            return result;
        }
    }
}
