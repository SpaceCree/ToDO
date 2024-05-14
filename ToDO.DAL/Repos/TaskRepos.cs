using ClassLibrary1.Entity;
using ClassLibrary1.Response;
using ToDO.DAL.Interfaces;

namespace ToDO.DAL.Repos;

public class TaskRepos : IBaseRepos<TaskEntity>
{
    private readonly AppDbContext _appDbContext;

    public TaskRepos(AppDbContext appDbContext)
    {
        
        _appDbContext = appDbContext;
    }


    public async Task Create(TaskEntity entity)
    {
        await _appDbContext.Tasks.AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public IQueryable<TaskEntity> GetAll()
    {
        return _appDbContext.Tasks;
    }

    public async Task Delete(TaskEntity entity)
    {
        _appDbContext.Tasks.Remove(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<TaskEntity> Update(TaskEntity entity)
    {
        _appDbContext.Tasks.Update(entity);
        await _appDbContext.SaveChangesAsync();

        return entity;
    }
}