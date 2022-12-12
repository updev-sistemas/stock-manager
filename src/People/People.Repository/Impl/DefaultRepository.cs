
using System.Linq.Expressions;
using UpDEV.StockManager.People.Repository.Contracts;

namespace UpDEV.StockManager.People.Repository.Impl
{
    public class DefaultRepository<T> : IDefaultRepository<T> where T : ISystemEntityBase
    {
        public DefaultRepository()
        {
        }

        public int Count(Expression<Func<T, bool>>? expression)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<T, bool>>? expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>>? expression)
        {
            throw new NotImplementedException();
        }

        public T? Find(long id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        public T? SaveOrUpdate(T target)
        {
            throw new NotImplementedException();
        }
    }
}
