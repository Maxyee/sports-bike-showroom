using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsBike.Models;

namespace SportsBike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        private static List<Motorcycle> _motorcycle = new List<Motorcycle>();

        // Get API motorcycle
        [HttpGet]
        public ActionResult<IEnumerable<Motorcycle>> Get()
        {
            return Ok(_motorcycle);
        }

        [HttpGet("{id}")]
        public ActionResult<Motorcycle> Get(int id)
        {
            var motorcycleItem = _motorcycle.Find(item => item.Id == id);
            if(motorcycleItem == null)
            {
                return NotFound();
            }

            return Ok(motorcycleItem);
        }

        // POST API motorcycle
        [HttpPost]
        public ActionResult<Motorcycle> Post([FromBody] Motorcycle motorcycle)
        {
            motorcycle.Id = _motorcycle.Count + 1;
            _motorcycle.Add(motorcycle);

            return CreatedAtAction(nameof(Get), new { id = motorcycle.Id }, motorcycle);
        }

        // PUT API motorcycle
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Motorcycle updatedMotorcycle)
        {
            var existingMotorcycle = _motorcycle.Find(item => item.Id == id);
            if(existingMotorcycle == null)
            {
                return NotFound();
            }

            existingMotorcycle.Model = updatedMotorcycle.Model;
            existingMotorcycle.Year = updatedMotorcycle.Year;
            existingMotorcycle.Price = updatedMotorcycle.Price;
            existingMotorcycle.Engine = updatedMotorcycle.Engine;
            existingMotorcycle.Datetime = updatedMotorcycle.Datetime;

            return NoContent();
        }

        // DELETE API motorcycle
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var motorcycleItem = _motorcycle.Find(item => item.Id == id);
            if (motorcycleItem == null)
            {
                return NotFound();
            }

            _motorcycle.Remove(motorcycleItem);

            return NoContent();
        }
    }
}
