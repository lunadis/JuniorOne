﻿using JuniorOne.Blog.Aplication.ViewModel.Usuarios;
using System;
using System.Collections.Generic;

namespace JuniorOne.Blog.Aplication.ViewModel
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Create_at { get; set; }

        public int IdAuthor { get; set; }
        public UserAuthorPostViewModel Author { get; set; }

        public IEnumerable<PostsCategoriesViewModel> categories { get; set; }
        public IEnumerable<PostsTagsViewModel> PostsTags { get; set; }
    }
}
