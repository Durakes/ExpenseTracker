namespace ExpenseTracker.Services;
public interface IService<TEntity> where TEntity : class
{
    Task<TEntity> GetById(int id);
    Task<IEnumerable<TEntity>> GetAll();
    Task Add(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);
}