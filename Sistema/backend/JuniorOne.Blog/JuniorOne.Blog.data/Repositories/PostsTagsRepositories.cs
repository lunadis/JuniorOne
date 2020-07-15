using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;

namespace JuniorOne.Blog.Data.Repositories
{
    public class PostsTagsRepositories : RepositoriesBase<PostsTags>, IPostsTagsReporitoires
    {
        public PostsTagsRepositories(Contexto db) : base(db)
        {
        }
    }
}