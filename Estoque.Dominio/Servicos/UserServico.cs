using Estoque.Dominio.Entities;
using Estoque.Dominio.Interfaces.Repositorios;
using Estoque.Dominio.Interfaces.Servicos;
using Estoque.Dominio.Servicos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Dominio.Servicos
{
    public class UserServico : ServicoBase<User>, IUserService
    {
        public UserServico(IUserRepository repositorio)
            : base(repositorio)
        {

        }
    }
}
