using JuniorOne.Blog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Domain.Models
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string TagName { get; set; }

        public IEnumerable<PostsTags> PostsTags { get; set; }
    }
}
