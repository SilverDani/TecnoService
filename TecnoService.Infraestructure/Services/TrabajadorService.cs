using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.Infraestructure.Services
{
    public class TrabajadorService : ServiceBase<TrabajadorModel>, ITrabajadorService
    {
        public TrabajadorService(ITrabajadorRepository repTrabajador) : base(repTrabajador)
        {

        }
    }
}
