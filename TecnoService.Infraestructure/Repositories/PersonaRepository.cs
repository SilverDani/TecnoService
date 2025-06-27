using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class PersonaRepository : RepositoryBase<PersonaModel>, IPersonaRepository
    {
        public PersonaRepository(ServiceContext ConPersona) : base(ConPersona)
        {

        }
    }
}
