using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using ProductManagementDemo.Models;
namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<Product> GetProductList()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception e)
            {
            }

            return listProducts;
        }

        public static void SaveProduct(Product product)
        {
            try
            {
                using var context = new MyStoreContext();
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public static void UpdateProduct(Product product)
        {
            try
            {
                using var context = new MyStoreContext();
                context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
        }

        public static void DeleteProduct(Product product)
        {
            try
            {
                using var context = new MyStoreContext();
                var p1 = context.Products.SingleOrDefault(c => c.ProductId == product.ProductId);
                context.Products.Remove(p1);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Product GetProductById(int id)
        {
            using var context = new MyStoreContext();
            return context.Products.SingleOrDefault(c => c.ProductId.Equals(id));
        }


    }
}