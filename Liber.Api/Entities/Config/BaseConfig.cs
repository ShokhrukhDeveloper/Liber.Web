using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liber.Api.Entities.Config;

public class BaseConfig<T> : IEntityTypeConfiguration<T> where T : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        _ = builder.Property(p => p.CreatedAt).IsRequired();
        _ = builder.HasKey(k => k.Id);
    }
}