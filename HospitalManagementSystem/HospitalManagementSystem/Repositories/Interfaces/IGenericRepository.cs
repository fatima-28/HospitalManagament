using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Add(T entity);
        Task<T> AddAsync(T entity);
        void Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(T entity);
        Task<T> DeleteAsync(T entity);
        IEnumerable<T> GetAll(Expression<Func<T,bool>> expression = null,Func<IQueryable<T>,IOrderedQueryable<T> > orderBy=null,string IncludeProperties="");


    }
}
