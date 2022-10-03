
using Microsoft.AspNetCore.Mvc;
using ShopApi.Database;
using ShopAPI.Database;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfoController : ControllerBase
    {
        ProductInfoRepository repository = null;

        public ProductInfoController(ShopContext context)
        {
            this.repository = new ProductInfoRepository(context);
        }
        //GET: api/<ProductInfoController>
        [HttpGet]

        public IEnumerable<ProductInfo> Get()
        {
            return repository.getProducts();
        }

        //GET api/<ProductInfoController>/5
        [HttpGet("{id}")]
        public string Get(int productId)
        {
            return "value";
        }
        // POST api/<FoodInfoController>
        [HttpPost]
        public void Post([FromBody] ProductInfo product)
        {
            repository.addProduct(product);
        }

        // PUT api/<ProductInfoController>/5
        [HttpPut]
        public void Put([FromBody] ProductInfo product)
        {
            repository.updateProduct(product);
        }

        // DELETE api/<ProductInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int productId)
        {
            repository.deleteProduct(productId);
        }

    }
}
