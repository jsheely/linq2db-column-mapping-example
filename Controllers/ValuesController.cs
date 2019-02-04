using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lin2db_column_mapping.Components.Database;
using lin2db_column_mapping.Models;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;

namespace lin2db_column_mapping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DbContext dbContext;

        public ValuesController(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAsync()
        {
            var products = await dbContext.Product.ToListAsync();
            return products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
