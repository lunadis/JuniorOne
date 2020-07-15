using JuniorOne.Blog.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace JuniorOne.Blog.Domain.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Create_at { get; set; }

        public int IdAuthor { get; set; }
        public User Author { get; set; }

        public IEnumerable<PostsCategories> categories { get; set; }
        public IEnumerable<PostsTags> PostsTags { get; set; }
    }
}