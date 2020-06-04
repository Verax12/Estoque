using Estoque.Aplicacao.DTO.Base;
using Estoque.Dominio.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Aplicacao.Interfaces.Base
{
    public interface IAppBase<T, TDTO>
          where T : BaseEntity
          where TDTO : DTOBase
    {
        int Incluir(TDTO entidade);
        void Excluir(int id);
        void Excluir(TDTO entidade);
        void Alterar(TDTO entidade);
        TDTO SelecionarPorId(int id);
        IEnumerable<TDTO> SelecionarTodos();
    }
}
