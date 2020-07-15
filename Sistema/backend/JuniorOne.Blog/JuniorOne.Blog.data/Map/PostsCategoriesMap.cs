using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorOne.Blog.Data.Map
{
    public class PostsCategoriesMap : IEntityTypeConfiguration<PostsCategories>
    {
        public void Configure(EntityTypeBuilder<PostsCategories> builder)
        {
            builder.ToTable(nameof(PostsCategories));

            builder.HasKey(pc => new {pc.IdCategory, pc.IdPost, pc.Id });
            builder.Property(pc => pc.Id)
                .UseIdentityColumn();

            builder.HasOne<Category>(pc => pc.Category)
                   .WithMany(pc => pc.PostCategories)
                   .HasForeignKey(pc => pc.IdCategory);

            builder.HasOne<Post>(pc => pc.Post)
                .WithMany(p => p.categories)
                .HasForeignKey(pc => pc.IdPost);
        }
    }
}