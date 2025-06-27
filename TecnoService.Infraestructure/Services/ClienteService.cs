﻿using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Interfaces.Service;
using TecnoService.Core.Models;

namespace TecnoService.Infraestructure.Services
{
    public class ClienteService: ServiceBase<ClienteModel>, IClienteService
    {
        public ClienteService(IClienteRepository repCliente) : base(repCliente)
        {

        }
    }
}
