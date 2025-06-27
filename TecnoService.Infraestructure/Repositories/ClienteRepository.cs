using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class ClienteRepository : RepositoryBase<ClienteModel>, IClienteRepository
    {
        public ClienteRepository(ServiceContext ConCliente) : base(ConCliente)
        {

        }
    }
}
