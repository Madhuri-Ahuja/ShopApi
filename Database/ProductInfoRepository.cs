using Microsoft.EntityFrameworkCore;
using ShopApi.Database;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Database
{
    public class ProductInfoRepository
    {
        ShopContext context = null;

        public ProductInfoRepository(ShopContext context)
        {
            this.context = context;
        }
        public IEnumerable<ProductInfo> getProducts()
        {
            return context.ProductInfo.ToList();
        }
        public void addProduct(ProductInfo product)
        {
            context.ProductInfo.Add(product);
            context.SaveChanges();
        }
        public void updateProduct(ProductInfo product)
        {
            context.Entry<ProductInfo>(product).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void deleteProduct(int productId)
        {
            ProductInfo product = context.ProductInfo.Find(productId);
            context.ProductInfo.Remove(product);
            context.SaveChanges();

        }


    }
}
