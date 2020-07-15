using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;

namespace JuniorOne.Blog.Data.Repositories
{
    public class PostsCategoriesRepositories : RepositoriesBase<PostsCategories>, IPostsCategoriesRepositories
    {
        public PostsCategoriesRepositories(Contexto db) : base(db)
        {
        }
    }
}