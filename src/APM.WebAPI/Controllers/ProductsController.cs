using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using APM.WebAPI.models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace APM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        //GET: api/products
        [HttpGet("")]
        public IEnumerable<Product> Get()
        {
            return _repository.Retrieve();
        }

        //GET: api/products/search
        //[HttpGet("{search}")]
        //public IEnumerable<Product> Get(string search)
        //{
        //    return _repository.Retrieve().Where(p => p.ProductCode.ToLower().Contains(search.ToLower()));
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            if (id > 0) {
                return _repository.Retrieve().FirstOrDefault(p=>p.ProductId == id);
            }
            else
            {
                return _repository.Create();
            }
        }

        // POST api/Products
        [HttpPost]
        public void Post([FromBody]Product product)
        {
            _repository.Save(product);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product)
        {
            _repository.Save(id, product);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
