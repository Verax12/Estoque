using Estoque.Dominio.Entities.Base;
using Estoque.Dominio.Interfaces.Repositorios.Base;
using Estoque.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Infra.Data.Repository.Base
{
    public class RepositorioBase<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        protected readonly EstoqueContext _contexto;

        public RepositorioBase(EstoqueContext contexto)
            : base()
        {
            _contexto = contexto;
        }

        public void Alterar(T entidade)
        {
            _contexto.Set<T>().Update(entidade);
            _contexto.SaveChanges();

        }

        public void Excluir(int id)
        {
            var entidade = SelecionarPorId(id);
            if (entidade != null)
            {
                _contexto.Set<T>().Remove(entidade);
                _contexto.SaveChanges();
            }
        }

        public void Excluir(T entidade)
        {

            _contexto.Set<T>().Remove(entidade);
            _contexto.SaveChanges();

        }

        public int Incluir(T entidade)
        {
            int id = _contexto.Set<T>().Add(entidade).Entity.Id;
            _contexto.SaveChanges();
            return id;
        }

        public T SelecionarPorId(int id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public IEnumerable<T> SelecionarTodos()
        {
            return _contexto.Set<T>().ToList();
        }
    }
}
