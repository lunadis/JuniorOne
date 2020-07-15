using JuniorOne.Blog.Data.Map;
using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JuniorOne.Blog.data
{
    public class Contexto : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostsCategories> PostsCategories { get; set; }
        public DbSet<PostsTags> PostsTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        public Contexto(DbContextOptions<Contexto> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CaterogoryMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new PostsCategoriesMap());
            modelBuilder.ApplyConfiguration(new PostsTagsMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}