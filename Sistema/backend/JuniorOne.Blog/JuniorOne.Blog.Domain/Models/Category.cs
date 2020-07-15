using JuniorOne.Blog.Domain.Interfaces;
using System.Collections.Generic;

namespace JuniorOne.Blog.Domain.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<PostsCategories> PostCategories { get; set; }
    }
}