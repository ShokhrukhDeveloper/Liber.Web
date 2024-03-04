using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liber.Api.Entities.Config;

public class StudentConfig : BaseConfig<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);
        _ = builder.HasMany(v => v.Books)
            .WithOne(o => o.User)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        _ = builder.HasMany(v => v.Sessions)
            .WithOne(o => o.User)
            .HasForeignKey(f => f.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
        _ = builder.HasOne(v => v.Password)
            .WithOne(o => o.User)
            .HasForeignKey<Password>(e => e.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}