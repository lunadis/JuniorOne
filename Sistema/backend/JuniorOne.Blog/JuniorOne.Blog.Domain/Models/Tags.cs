using JuniorOne.Blog.Domain.Interfaces;
using System.Collections.Generic;

namespace JuniorOne.Blog.Domain.Models
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string TagName { get; set; }

        public IEnumerable<PostsTags> PostsTags { get; set; }
    }
}