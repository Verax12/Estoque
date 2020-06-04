using AutoMapper;
using Estoque.Aplicacao.DTO;
using Estoque.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Estoque.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<User, DTOUser>();
            CreateMap<DTOUser, User>();
        }
    }
}
