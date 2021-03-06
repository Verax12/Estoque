﻿using Estoque.Dominio.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Dominio.Interfaces.Repositorios.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {

        int Incluir(T entidade);
        void Excluir(int id);
        void Excluir(T entidade);
        void Alterar(T entidade);
        T SelecionarPorId(int id);
        IEnumerable<T> SelecionarTodos();
    }

}
