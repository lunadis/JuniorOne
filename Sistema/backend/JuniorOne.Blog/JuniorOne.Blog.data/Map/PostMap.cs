using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorOne.Blog.Data.Map
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable(nameof(Post));

            builder.HasKey(p => new { p.IdAuthor});

            builder.Property(p => p.Id)
                   .UseIdentityColumn();

            builder.HasOne<User>(p => p.Author)
                   .WithMany(u => u.Posts)
                   .HasForeignKey(p => p.IdAuthor);
        }
    }
}