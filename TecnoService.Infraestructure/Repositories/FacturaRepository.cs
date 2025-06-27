using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class FacturaRepository : RepositoryBase<FacturaModel>, IFacturaRepository
    {
        public FacturaRepository(ServiceContext ConFactura) : base(ConFactura)
        {

        }
    }
}
