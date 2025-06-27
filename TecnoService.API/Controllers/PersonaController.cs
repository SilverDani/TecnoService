using Microsoft.AspNetCore.Mvc;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService PersonaServ;
        public PersonaController(IPersonaService PersonaServicio)
        {
            PersonaServ = PersonaServicio;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Personas = await PersonaServ.GetAllAsync();
            return Ok(Personas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int ID)
        {
            var Persona = await PersonaServ.GetByIdAsync(ID);
            if (Persona == null)
            {
                return NotFound();
            }

            return Ok(Persona);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Persona Persona)
        {
            await PersonaServ.AddAsync(Persona);

            return CreatedAtAction(nameof(GetById), new { id = Persona.IDPersona }, Persona);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int ID, Persona Persona)
        {
            if (ID != Persona.IDPersona)
            {
                return BadRequest();
            }

            await PersonaServ.UpdateAsync(Persona);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ID)
        {
            await PersonaServ.DeleteAsync(ID);

            return NoContent();
        }


        //=========================================
    }
}
