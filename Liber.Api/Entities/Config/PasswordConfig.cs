using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liber.Api.Entities.Config;

public class PasswordConfig : BaseConfig<Password>
{
    public override void Configure(EntityTypeBuilder<Password> builder)
    {
        base.Configure(builder);
        builder.Property(e=>e.PasswordHash).HasColumnType("char(64)");
    }
}