using Estoque.Aplicacao.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Aplicacao.DTO
{
   public class DTOUser : DTOBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
