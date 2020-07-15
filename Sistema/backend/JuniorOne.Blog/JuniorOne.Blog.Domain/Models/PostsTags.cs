using JuniorOne.Blog.Domain.Interfaces;

namespace JuniorOne.Blog.Domain.Models
{
    public class PostsTags : IEntity
    {
        public int Id { get; set; }

        public int IdPost { get; set; }
        public Post Post { get; set; }
        public int IdTag { get; set; }
        public Tag Tag { get; set; }
    }
}