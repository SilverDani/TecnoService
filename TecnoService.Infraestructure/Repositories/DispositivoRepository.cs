using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class DispositivoRepository : RepositoryBase<DispositivoModel>, IDispositivoRepository
    {
        public DispositivoRepository(ServiceContext ConDispositivo) : base(ConDispositivo)
        {

        }
    }
}
