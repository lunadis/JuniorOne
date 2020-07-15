using JuniorOne.Blog.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace JuniorOne.Blog.Domain.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Registered_in { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}