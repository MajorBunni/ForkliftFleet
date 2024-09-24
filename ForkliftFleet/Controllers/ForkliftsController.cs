using ForkliftFleet.Data;
using ForkliftFleet.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ForkliftFleet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForkliftsController : ControllerBase
    {
        private readonly ForkliftFleetDbContext dbContext;

        public ForkliftsController(ForkliftFleetDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllForklisfts()
        {
            var forklifts = dbContext.Forklifts.ToList();
            return Ok(forklifts);
        }

        [HttpPost]
        public IActionResult AddForklift(Models.AddForkliftRequestDTO request)
        {
            var domainModelForklist = new Forklift
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                ModelNumber = request.ModelNumber,
                ManufacturingDate = request.ManufacturingDate,
            };

            dbContext.Forklifts.Add(domainModelForklist);
            dbContext.SaveChanges();

            return Ok(domainModelForklist);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteContact(Guid id)
        {
            var forklift = dbContext.Forklifts.Find(id);

            if (forklift is not null)
            {
                dbContext.Forklifts.Remove(forklift);
                dbContext.SaveChanges();
            }

            return Ok();
        }
    }
}
