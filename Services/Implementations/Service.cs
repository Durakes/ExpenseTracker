
using ExpenseTracker.Repository;

namespace ExpenseTracker.Services;
public class Service<TEntity> : IService<TEntity> where TEntity : class
{
    protected readonly IRepository<TEntity> _repository;
    public Service(IRepository<TEntity> repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _repository.GetAll();
    }
    public async Task<TEntity> GetById(int id)
    {
        TEntity? entity =  await _repository.GetById(id);
        return entity;
    }
    public Task Add(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public Task Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public Task Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }
}