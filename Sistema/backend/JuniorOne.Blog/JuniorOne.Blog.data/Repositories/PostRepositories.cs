using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Models;

namespace JuniorOne.Blog.Data.Repositories
{
    public class PostRepositories : RepositoriesBase<Post>
    {
        public PostRepositories(Contexto db) : base(db)
        {
        }
    }
}