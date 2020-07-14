using JuniorOne.Blog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Domain.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<PostsCategories> Categories { get; set; }
    }
}
