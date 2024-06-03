using System.Linq.Expressions;

namespace OtoServisSatis.Data.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Save();

        //Asenkron Metotlar
        Task<T> FindAsyc(int id);
        Task<T> GetAsyc(Expression<Func<T, bool>> expression);
        Task< List<T>> GetAllAsync();
        Task<List<T>> GetAllAsyc(Expression<Func<T, bool>> expression);
        Task AddAsycn(T entity);
        Task<int> SaveAsync();
    }
}
