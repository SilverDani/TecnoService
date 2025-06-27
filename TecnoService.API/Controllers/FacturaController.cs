using Microsoft.AspNetCore.Mvc;
using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService FacturaServ;
        public FacturaController(IFacturaService facturaServicio)
        {
            FacturaServ=facturaServicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var Factura = await FacturaServ.GetAllAsync();
            return Ok(Factura);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int ID)
        {
            var Factura = await FacturaServ.GetByIdAsync(ID);
            if (Factura == null)
            {
                return NotFound();
            }
            return Ok(Factura);
        }

        [HttpPost]
        public async Task<IActionResult> Create (Factura factura)
        {
            await FacturaServ.AddAsync(factura);

            return CreatedAtAction(nameof(GetById
                ), factura);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int ID, Factura Factura)
        {
            if (ID != Factura.IDFactura)
            {
                return BadRequest();
            }
            await FacturaServ.UpdateAsync(Factura);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ID) {
            await FacturaServ.DeleteAsync(ID);

            return NoContent();
        }




        //===========================================
    }
}
