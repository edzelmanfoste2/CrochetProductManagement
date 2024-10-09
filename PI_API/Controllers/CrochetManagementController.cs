using Microsoft.AspNetCore.Mvc;
using Client;
using ProductInventoryManagementModel;
using PI_ManagamentData;
using PI_ManagementServices;
using PI_API;


namespace PI_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrochetManagementController : ControllerBase
    {
        GetProducts _getProducts;
        ProductsServices _productServices;
        MailSet _mailset;
        MailSet2 _mailset2;


        public CrochetManagementController()
        {
            _getProducts = new GetProducts();
            _productServices = new ProductsServices();
            _mailset = new MailSet();
            _mailset2 = new MailSet2();
        }

        [HttpGet]
        //public IEnumerable<Client.API.User> GetUsers()
        public IEnumerable<PI_API.CrochetProduct> GetProducts()
        {
            var getproducts = _getProducts.GetAllProducts();

            List<PI_API.CrochetProduct> pr = new List<PI_API.CrochetProduct>();

            foreach (var products in getproducts)
            {
                pr.Add(new PI_API.CrochetProduct { ID = products.ID, name = products.name, productType = products.productType, availability = products.availability, description = products.description, category = products.category, material = products.material, size = products.size, });
            }

            return pr;
        }

        [HttpPost]
        public JsonResult AddProduct(CrochetProduct produceCrochet)
        {
            //var mailset = _mailset;

            var result = _productServices.CreateProducts(produceCrochet.ID, produceCrochet.name, produceCrochet.productType, produceCrochet.availability, produceCrochet.description, produceCrochet.category, produceCrochet.material, produceCrochet.size);

            //var mailset = _mailset;
            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateProduct(CrochetProduct produceCrochet)
        {
            var result = _productServices.UpdateProducts(produceCrochet.ID, produceCrochet.name, produceCrochet.productType, produceCrochet.availability, produceCrochet.description, produceCrochet.category, produceCrochet.material, produceCrochet.size);

            var mailset2 = _mailset2;
            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteProduct(CrochetProduct produceCrochet)
        {

            var deleteProduce = new ProductInventoryManagementModel.CrochetProducts
            {
                ID = produceCrochet.ID
            };

            var result = _productServices.DeleteProducts(deleteProduce);   

            return new JsonResult(result);
        }
    }
}
