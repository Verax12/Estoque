using Estoque.Aplicacao.Interfaces;
using Estoque.Aplicacao.Interfaces.Base;
using Estoque.Aplicacao.Servicos;
using Estoque.Aplicacao.Servicos.Base;
using Estoque.Dominio.Interfaces.Repositorios;
using Estoque.Dominio.Interfaces.Repositorios.Base;
using Estoque.Dominio.Interfaces.Servicos;
using Estoque.Dominio.Interfaces.Servicos.Base;
using Estoque.Dominio.Servicos;
using Estoque.Dominio.Servicos.Base;
using Estoque.Infra.Data.Repository;
using Estoque.Infra.Data.Repository.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Infra.IoC
{
   public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IUserApp, UserApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IUserService, UserServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IBaseRepository<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
