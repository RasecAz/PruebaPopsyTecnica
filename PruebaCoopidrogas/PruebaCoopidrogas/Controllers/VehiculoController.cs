using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaCoopidrogas.Etityes;

namespace PruebaCoopidrogas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDb;

        public VehiculoController(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }
        [HttpPost]
        public async Task<ActionResult> Post(Vehiculo vehiculo) 
        {
            _applicationDb.Add(vehiculo);
            await _applicationDb.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> Get()
        {
            return await _applicationDb.Vehiculos.ToListAsync();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.Id)
            {
                return BadRequest();
            }
            _applicationDb.Entry(vehiculo).State= EntityState.Modified;
            await _applicationDb.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _applicationDb.Vehiculos.Where(d => d.Id == id).ExecuteDeleteAsync();

            if(result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
