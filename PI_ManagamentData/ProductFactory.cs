using ProductInventoryManagementModel;

namespace PI_ManagamentData
{
    public class ProductFactory
    {
        private List<CrochetProducts> crochetProducts = new List<CrochetProducts>();

        public List<CrochetProducts> GetCrochetProducts()
        {
            crochetProducts.Add(CreateProducts("name1", "product type 1", "description 1", "category 1", "material" , "0.1", "1"));
            crochetProducts.Add(CreateProducts("name2", "product type 2", "description 2", "category 2", "material", "0.2", "2"));
            crochetProducts.Add(CreateProducts("name3", "product type 3", "description 3", "category 3", "material", "9.3", "3"));
            crochetProducts.Add(CreateProducts("name4", "product type 4", "description 4", "category 4", "material", "0.4", "4"));

            return crochetProducts;
        }

        private CrochetProducts CreateProducts(string name, string productType, string description, string category, string material, string size, string ID)
        {
            CrochetProducts products = new CrochetProducts
            {
                name = name,
                productType = productType,
                description = description,
                category = category, 
                material = material,
                size = size,
                ID = ID 
            };

            return products;
        }
    }
}
