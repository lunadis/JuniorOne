using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorOne.Blog.Data.Map
{
    public class CaterogoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));
            builder.HasKey(c => new { c.Id });

            builder.Property(c => c.Id)
                   .UseIdentityColumn();

            builder.Property(c => c.Description)
                   .HasColumnType("varchar(100)")
                   .IsRequired();
        }
    }
}