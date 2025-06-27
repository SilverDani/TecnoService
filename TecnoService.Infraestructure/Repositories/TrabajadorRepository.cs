using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class TrabajadorRepository : RepositoryBase<TrabajadorModel>, ITrabajadorRepository
    {
        public TrabajadorRepository(ServiceContext ConTrabajador) : base(ConTrabajador)
        {

        }
    }
}
