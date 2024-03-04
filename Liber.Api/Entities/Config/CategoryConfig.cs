using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liber.Api.Entities.Config;

public class CategoryConfig : BaseConfig<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);
        _ = builder.HasMany(v => v.SubCategories)
            .WithOne(o => o.Category)
            .HasForeignKey(f => f.category_id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}