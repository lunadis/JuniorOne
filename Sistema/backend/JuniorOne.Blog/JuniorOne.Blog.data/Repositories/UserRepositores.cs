using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;

namespace JuniorOne.Blog.Data.Repositories
{
    public class UserRepositores : RepositoriesBase<User>, IUserRepositorie
    {
        public UserRepositores(Contexto db) : base(db)
        {
        }
    }
}