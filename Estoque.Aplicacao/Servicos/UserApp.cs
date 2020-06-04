using AutoMapper;
using Estoque.Aplicacao.DTO;
using Estoque.Aplicacao.Interfaces;
using Estoque.Aplicacao.Servicos.Base;
using Estoque.Dominio.Entities;
using Estoque.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Aplicacao.Servicos
{
   public class UserApp : ServicoAppBase<User, DTOUser>, IUserApp
    {
        public UserApp(IMapper iMapper, IUserService userService):base(iMapper, userService)
        {

        }
    }
}