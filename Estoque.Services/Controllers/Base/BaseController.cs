using Estoque.Aplicacao.DTO.Base;
using Estoque.Aplicacao.Interfaces.Base;
using Estoque.Dominio.Entities.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Services.Controllers.Base
{
    public class BaseController
    {
        public class ControllerBase<Entidade, EntidadeDTO> : Controller where Entidade : BaseEntity where EntidadeDTO : DTOBase
        {
            readonly protected IAppBase<Entidade, EntidadeDTO> _IApp;

            public ControllerBase(IAppBase<Entidade, EntidadeDTO> IApp)
            {
                _IApp = IApp;
            }

            [HttpGet]
            [Route("")]
            public IActionResult Listar()
            {
                try
                {
                    var dado = _IApp.SelecionarTodos();
                    return new OkObjectResult(dado);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpGet]
            [Route("{id}")]
            public IActionResult SelecionarPorId(int id)
            {
                if(id == 0) id = 1;

                try
                {
                    var dado = _IApp.SelecionarPorId(id);
                    return new OkObjectResult(dado);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpPost]
            public IActionResult Incluir([FromBody] EntidadeDTO dado)
            {
                try
                {
                    return new OkObjectResult(_IApp.Incluir(dado));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpPut]
            public IActionResult Alterar([FromBody] EntidadeDTO dado)
            {
                try
                {
                    _IApp.Alterar(dado);
                    return new OkObjectResult(true);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

            [HttpDelete]
            [Route("{id}")]
            public IActionResult Excluir(int id)
            {
                try
                {
                    _IApp.Excluir(id);
                    return new OkObjectResult(true);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
