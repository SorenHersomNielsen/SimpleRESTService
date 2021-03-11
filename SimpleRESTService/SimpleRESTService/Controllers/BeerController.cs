using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleRESTService.Manager;
using SimpleRESTService.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        // the controller is available om api/Beer
        private readonly BeerManager beerManager = new BeerManager();

        // GET: api/<BeerController>
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return beerManager.GetAll();
        }

        // GET api/<BeerController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return beerManager.GetbyId(id);
        }

        // POST api/<BeerController>
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return beerManager.Add(value);
        }

        // PUT api/<BeerController>/5
        [HttpPut("{id}")]
        public Beer Put(int id, [FromBody] Beer value)
        {
            return beerManager.Update(id,value);
        }

        // DELETE api/<BeerController>/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return beerManager.Delete(id);
        }
    }
}
