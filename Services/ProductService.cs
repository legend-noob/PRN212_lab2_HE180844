using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductRespository;

        public ProductService()
        {
            iProductRespository = new ProductRepository();
        }

        public void DeleteProduct(Product product)
        {
            iProductRespository.DeleteProduct(product);
        }

        public Product GetProductById(int id)
        {
            return iProductRespository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return iProductRespository.GetProducts();
        }

        public void SaveProduct(Product product)
        {
            iProductRespository.SaveProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            iProductRespository.UpdateProduct(product);
        }
    }
}
