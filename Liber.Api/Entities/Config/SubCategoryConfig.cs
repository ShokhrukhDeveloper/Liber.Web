using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liber.Api.Entities.Config;

public class SubCategoryConfig : BaseConfig<SubCategory>
{
    public override void Configure(EntityTypeBuilder<SubCategory> builder)
    {
        base.Configure(builder);
        _ = builder.HasMany(v => v.Books)
            .WithOne(o => o.SubCategory)
            .HasForeignKey(f => f.SubjectId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}