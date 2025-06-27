﻿using TecnoService.Core.Interfaces.Repository;
using TecnoService.Core.Models;
using TecnoService.Infraestructure.Data;

namespace TecnoService.Infraestructure.Repositories
{
    public class InDisRepository : RepositoryBase<InDisModel>, IInDisRepository
    {
        public InDisRepository(ServiceContext ConInDis) : base(ConInDis)
        {

        }
    }
}
