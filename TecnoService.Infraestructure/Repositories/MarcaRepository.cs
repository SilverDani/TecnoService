using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class MarcaRepository : RepositoryBase<MarcaModel>, IMarcaRepository
    {
        public MarcaRepository(ServiceContext ConMarca) : base(ConMarca)
        {

        }
    }
}
