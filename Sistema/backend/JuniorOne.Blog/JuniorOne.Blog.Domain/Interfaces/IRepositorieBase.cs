using System;
using System.Collections.Generic;

namespace JuniorOne.Blog.Domain.Interfaces
{
    public interface IRepositorieBase<T> : IDisposable where T : class, IEntity
    {
        bool Save(T entity);
        bool Update(T entity);
        T Select(int id);
        T Delete(int id);
        IEnumerable<T> Index();
    }
}
