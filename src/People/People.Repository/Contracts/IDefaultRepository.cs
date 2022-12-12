using System.Linq.Expressions;

namespace UpDEV.StockManager.People.Repository.Contracts
{
    public interface IDefaultRepository<T> where T : ISystemEntityBase
    {
        IQueryable<T> Query();
        IQueryable<T> Find(Expression<Func<T, bool>>? expression);
        ICollection<T> GetAll();
        T? Find(long id);
        T? SaveOrUpdate(T target);
        bool Exists(Expression<Func<T, bool>>? expression);
        int Count(Expression<Func<T, bool>>? expression);
    }
}
