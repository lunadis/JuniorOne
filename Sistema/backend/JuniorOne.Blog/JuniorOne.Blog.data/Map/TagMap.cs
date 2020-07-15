using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorOne.Blog.Data.Map
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable(nameof(Tag));
            builder.HasKey(t => new { t.Id });
            builder.Property(t => t.Id)
                   .UseIdentityColumn();

            builder.Property(t => t.TagName)
                   .HasColumnType("varchar(100)");
        }
    }
}