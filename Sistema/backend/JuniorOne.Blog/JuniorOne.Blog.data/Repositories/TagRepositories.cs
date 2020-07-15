using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;

namespace JuniorOne.Blog.Data.Repositories
{
    public class TagRepositories : RepositoriesBase<Tag>, ITagRepositorie
    {
        public TagRepositories(Contexto db) : base(db)
        {
        }
    }
}