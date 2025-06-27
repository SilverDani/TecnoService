using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivoController : ControllerBase
    {
        private readonly IDispositivoService dispositivoServ;
        public DispositivoController(IDispositivoService dispositivoServicio)
        {
            dispositivoServ = dispositivoServicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var dispo = await dispositivoServ.GetAllAsync();
            return Ok(dispo);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int ID)
        {
            var dispo = await dispositivoServ.GetByIdAsync(ID);

            if(dispo == null)
            {
                return NotFound();
            }
            return Ok(dispo);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Dispositivo dispositivo){
            await dispositivoServ.AddAsync(dispositivo);

            return CreatedAtAction(nameof(GetById), new { ID = dispositivo.IDDispositivo }, dispositivo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int ID, Dispositivo dispo)
        {
            if(ID!= dispo.IDDispositivo)
            {
                return BadRequest();
            }
            await dispositivoServ.UpdateAsync(dispo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ID)
        {
            await dispositivoServ.DeleteAsync(ID);
            return NoContent();
        }



        //==================================================
    }
}
