using ExpenseTracker.Helpers;
namespace ExpenseTracker.Services;
public interface IService<TEntity> where TEntity : class
{
    Task<ResultObject<TEntity>> GetById(int id);
    Task<ResultList<TEntity>> GetAll();
    Task Add(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);
}