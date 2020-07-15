using JuniorOne.Blog.data;
using JuniorOne.Blog.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace JuniorOne.Blog.Data.Repositories
{
    public class RepositoriesBase<T> : IRepositorieBase<T> where T : class, IEntity
    {
        private readonly Contexto _Db;

        public RepositoriesBase(Contexto db)
        {
            _Db = db;
        }

        public T Delete(int id)
        {
            var entity = Select(id);
            _Db.Set<T>().Remove(entity);
            _Db.SaveChanges();
            return entity;
        }

        public void Dispose()
        {
            _Db.Dispose();
        }

        public IEnumerable<T> Index()
        {
            return _Db.Set<T>().ToList();
        }

        public bool Save(T entity)
        {
            _Db.Set<T>().Add(entity);
            int Entries = _Db.SaveChanges();
            return (Entries >= 1);
        }

        public T Select(int id)
        {
            return _Db.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public bool Update(T entity)
        {
            _Db.Set<T>().Update(entity);
            int Entries = _Db.SaveChanges();
            return (Entries >= 1);
        }
    }
}