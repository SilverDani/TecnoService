using Microsoft.AspNetCore.Mvc;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class InDisController : ControllerBase
    {
        private readonly IInDisService InDisServ;
        public InDisController(IInDisService InDisServicio)
        {
            InDisServ = InDisServicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var InDiss = await InDisServ.GetAllAsync();
            return Ok(InDiss);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int ID)
        {
            var InDis = await InDisServ.GetByIdAsync(ID);
            if (InDis == null)
            {
                return NotFound();
            }

            return Ok(InDis);
        }

        [HttpPost]
        public async Task<IActionResult> Create(InDis InDis)
        {
            await InDisServ.AddAsync(InDis);

            return CreatedAtAction(nameof(GetById), new { id = InDis.IDInDis }, InDis);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int ID, InDis InDis)
        {
            if (ID != InDis.IDInDis)
            {
                return BadRequest();
            }

            await InDisServ.UpdateAsync(InDis);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ID)
        {
            await InDisServ.DeleteAsync(ID);

            return NoContent();
        }


        //=========================================
    }
}
