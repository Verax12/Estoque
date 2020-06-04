using Estoque.Dominio.Entities.Base;
using Estoque.Dominio.Interfaces.Repositorios.Base;
using Estoque.Dominio.Interfaces.Servicos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Dominio.Servicos.Base
{
    public class ServicoBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected readonly IBaseRepository<T> repositorio;

        public ServicoBase(IBaseRepository<T> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alterar(T entidade)
        {
            repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }

        public void Excluir(T entidade)
        {
            repositorio.Excluir(entidade);
        }

        public int Incluir(T entidade)
        {
            return repositorio.Incluir(entidade);
        }

        public T SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }

        public IEnumerable<T> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }
    }
}
