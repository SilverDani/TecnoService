using Microsoft.AspNetCore.Mvc;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaService MarcaServ;
        public MarcaController(IMarcaService MarcaServicio)
        {
            MarcaServ = MarcaServicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var marcas = await MarcaServ.GetAllAsync();
            return Ok(marcas);
        }

        [HttpGet("{ID}")]
        public async Task<IActionResult> GetById(int ID)
        {
            var marca = await MarcaServ.GetByIdAsync(ID);
            if (marca == null)
            {
                return NotFound();
            }

            return Ok(marca);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Marca Marca)
        {
            await MarcaServ.AddAsync(Marca);

            return CreatedAtAction(nameof(GetById), new { id = Marca.IDMarca }, Marca);
        }

        [HttpPut("{ID}")]
        public async Task<IActionResult> Update(int ID, Marca Marca)
        {
            if (ID != Marca.IDMarca)
            {
                return BadRequest();
            }

            await MarcaServ.UpdateAsync(Marca);

            return NoContent();
        }

        [HttpDelete("{ID}")]
        public async Task<IActionResult> Delete(int ID)
        {
            await MarcaServ.DeleteAsync(ID);

            return NoContent();
        }


        //=========================================
    }
}
