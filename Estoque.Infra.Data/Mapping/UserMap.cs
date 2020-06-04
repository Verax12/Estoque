using Estoque.Dominio.Entities;
using Estoque.Infra.Data.Mapping.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.Infra.Data.Mapping
{
    public class UserMap : BaseMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder) 
        {
            base.Configure(builder);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Sobrenome).IsRequired().HasMaxLength(100);
        }

    }
}