using Estoque.Dominio.Entities;
using Estoque.Dominio.Interfaces.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Dominio.Interfaces.Repositorios
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
