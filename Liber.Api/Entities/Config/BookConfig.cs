using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liber.Api.Entities.Config;

public class BookConfig : BaseConfig<Book>
{
    
    public override void Configure(EntityTypeBuilder<Book> builder)
    {
        base.Configure(builder);
        _ = builder.HasOne(e=>e.Category).WithMany(e=>e.Books).OnDelete(DeleteBehavior.Cascade);
        _ = builder.HasOne(e=>e.SubCategory).WithMany(e=>e.Books).OnDelete(DeleteBehavior.Cascade);
        _ = builder.HasMany(e=>e.Images).WithOne(e=>e.Book).OnDelete(DeleteBehavior.Cascade);
    }
} 