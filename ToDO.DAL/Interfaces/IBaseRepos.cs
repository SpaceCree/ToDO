namespace ToDO.DAL.Interfaces;

public interface IBaseRepos<T>
{
    Task Create(T entity);
    IQueryable<T> GetAll();
    Task Delete(T entity);
    Task<T> Update(T entity);
}