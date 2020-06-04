using AutoMapper;
using Estoque.Aplicacao.DTO.Base;
using Estoque.Aplicacao.Interfaces.Base;
using Estoque.Dominio.Entities.Base;
using Estoque.Dominio.Interfaces.Servicos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Aplicacao.Servicos.Base
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : BaseEntity
        where TEntidadeDTO : DTOBase
    {
        protected readonly IServiceBase<TEntidade> _servico;
        protected readonly IMapper _iMapper;

        public ServicoAppBase(IMapper iMapper, IServiceBase<TEntidade> servico)
        {
            _iMapper = iMapper;
            _servico = servico;
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            _servico.Alterar(_iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id)
        {
            _servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            _servico.Excluir(_iMapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return _servico.Incluir(_iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            return _iMapper.Map<TEntidadeDTO>(_servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return _iMapper.Map<IEnumerable<TEntidadeDTO>>(_servico.SelecionarTodos());
        }
    }
}
