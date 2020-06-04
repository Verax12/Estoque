using Estoque.Dominio.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Dominio.Entities
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
