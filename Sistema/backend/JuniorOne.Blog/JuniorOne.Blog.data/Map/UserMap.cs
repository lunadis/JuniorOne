using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JuniorOne.Blog.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(u => new { u.Id });
            builder.Property(u => u.Id)
                .UseIdentityColumn();

            builder.Property(u => u.Registered_in)
                .HasColumnType("smalldatetime")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(u => u.Name)
                .HasColumnType("varchar(180)")
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnType("varchar(80)")
                .IsRequired();

            builder.Property(u => u.UserName)
                .HasColumnType("varchar(80)");
        }
    }
}