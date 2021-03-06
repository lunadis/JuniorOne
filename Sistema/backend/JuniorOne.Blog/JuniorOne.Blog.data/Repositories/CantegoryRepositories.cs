﻿using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;

namespace JuniorOne.Blog.Data.Repositories
{
    public class CantegoryRepositories : RepositoriesBase<Category>, ICategoryRepositorie
    {
        public CantegoryRepositories(Contexto db) : base(db)
        {
        }
    }
}