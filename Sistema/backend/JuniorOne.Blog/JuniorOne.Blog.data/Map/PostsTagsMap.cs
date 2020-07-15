using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorOne.Blog.Data.Map
{
    public class PostsTagsMap : IEntityTypeConfiguration<PostsTags>
    {
        public void Configure(EntityTypeBuilder<PostsTags> builder)
        {
            builder.ToTable(nameof(PostsTags));

            builder.HasKey(pt => new { pt.IdPost, pt.IdTag, pt.Id });
            builder.Property(pt => pt.Id)
                .UseIdentityColumn();

            builder.HasOne<Post>(pt => pt.Post)
                .WithMany(p => p.PostsTags)
                .HasForeignKey(pt => pt.IdPost);

            builder.HasOne<Tag>(pt => pt.Tag)
                .WithMany(t => t.PostsTags)
                .HasForeignKey(pt => pt.IdTag);
        }
    }
}