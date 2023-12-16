using ExpenseTracker.Repositories;
using ExpenseTracker.Helpers;
namespace ExpenseTracker.Services;
public class Service<TEntity> : IService<TEntity> where TEntity : class
{
    protected readonly IRepository<TEntity> _repository;
    public Service(IRepository<TEntity> repository)
    {
        _repository = repository;
    }
    public async Task<ResultList<TEntity>> GetAll()
    {
        IEnumerable<TEntity> resultList = await _repository.GetAll();
        
        ResultList<TEntity> result = new()
        {
            IsEmpty = false,
            Value = resultList,
            Message = "List of Entities full"
        };

        if(!resultList.ToList().Any())
        {
            result.IsEmpty = true;
            result.Message = "List is Empty";
        }
        
        return result;
    }
    public async Task<ResultObject<TEntity>> GetById(int id)
    {
        TEntity? entity = await _repository.GetById(id);
        ResultObject<TEntity> result = new()
        {
            Success = true,
            Value = entity,
            Message = $"Entity with ID {id} found."

        };
        if (entity is null)
        {
            result.Success = false;
            result.Message = $"Entity with ID {id} not found.";
        }
        return result;
    }
    public async Task Add(TEntity entity)
    {
        await _repository.Add(entity);
    }
    public async Task Update(TEntity entity)
    {
        await _repository.Update(entity);
    }
    public async Task Delete(TEntity entity)
    {
        await _repository.Delete(entity);
    }
}