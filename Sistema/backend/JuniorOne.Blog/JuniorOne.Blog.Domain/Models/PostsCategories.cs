using JuniorOne.Blog.Domain.Interfaces;

namespace JuniorOne.Blog.Domain.Models
{
    public class PostsCategories : IEntity
    {
        public int Id { get; set; }

        public int IdPost { get; set; }
        public Post Post { get; set; }

        public int IdCategory { get; set; }
        public Category Category { get; set; }
    }
}