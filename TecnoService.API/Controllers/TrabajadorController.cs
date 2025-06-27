using Microsoft.AspNetCore.Mvc;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class TrabajadorController : ControllerBase
    {
        private readonly ITrabajadorService TrabajadorServ;
        public TrabajadorController(ITrabajadorService TrabajadorServicio)
        {
            TrabajadorServ = TrabajadorServicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Trabajadors = await TrabajadorServ.GetAllAsync();
            return Ok(Trabajadors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int ID)
        {
            var Trabajador = await TrabajadorServ.GetByIdAsync(ID);
            if (Trabajador == null)
            {
                return NotFound();
            }

            return Ok(Trabajador);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Trabajador Trabajador)
        {
            await TrabajadorServ.AddAsync(Trabajador);

            return CreatedAtAction(nameof(GetById), new { id = Trabajador.IDTrabajador }, Trabajador);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int ID, Trabajador Trabajador)
        {
            if (ID != Trabajador.IDTrabajador)
            {
                return BadRequest();
            }

            await TrabajadorServ.UpdateAsync(Trabajador);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ID)
        {
            await TrabajadorServ.DeleteAsync(ID);

            return NoContent();
        }


        //=========================================
    }
}
