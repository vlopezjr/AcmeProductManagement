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
    public class ItemsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            var items = new List<Item>();
            items.Add(new Item { Key = 1, Id = "2cw", Type = 5 });
            items.Add(new Item { Key = 2, Id = "c-513", Type = 5 });
            items.Add(new Item { Key = 1, Id = "pw-45667", Type = 5 });

            return Json(items);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
