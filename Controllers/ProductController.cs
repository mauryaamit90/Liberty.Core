using Liberty.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Liberty.Core.Controllers
{
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public IEnumerable<Product> Get()
        {
            return GetProducts();
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public Product Get(int id)
        {
            return GetProducts().Find(e => e.Id == id);
        }
        
        // POST: api/Product
        [HttpPost("",Name = "Post")]
        public Product Post([FromBody] Product Product)
        {
            // Logic to create new Product
            return new Product();
        }
        
        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product Product)
        {
            // Logic to update an Product
        }
        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Product> GetProducts()
        {
            return new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name= "Bike 1",
                Model = "Storts",
                Status = "New Created",
                Color = new Color(){ },
                Engine = new Engine(){ },
                Lighting = new Lighting(){ },
                Seat = new Seat(){},
                Wheels = new Wheels(){ },
            },
            new Product()
            {
                 Id = 2,
                Name= "Bike 2",
                Model = "Storts",
                Status = "In Process",
                Color = new Color(){ },
                Engine = new Engine(){ },
                Lighting = new Lighting(){ },
                Seat = new Seat(){},
                Wheels = new Wheels(){ },
            },
            new Product()
            {
                 Id = 3,
                Name= "Bike 3",
                Model = "Storts",
                Status = "In Process",
                Color = new Color(){ },
                Engine = new Engine(){ },
                Lighting = new Lighting(){ },
                Seat = new Seat(){},
                Wheels = new Wheels(){ },
            }
        };
        }
    }
}
