using Estoque.Dominio.Entities;
using Estoque.Dominio.Interfaces.Repositorios;
using Estoque.Infra.Data.Context;
using Estoque.Infra.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Infra.Data.Repository
{
    public class UserRepository: RepositorioBase<User>, IUserRepository
    {
        public UserRepository(EstoqueContext contexto)
           : base(contexto)
        {
        }
    }
}
