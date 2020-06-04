using Estoque.Aplicacao.DTO;
using Estoque.Aplicacao.Interfaces.Base;
using Estoque.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Aplicacao.Interfaces
{
    public interface IUserApp : IAppBase<User, DTOUser>
    {
    }
}
