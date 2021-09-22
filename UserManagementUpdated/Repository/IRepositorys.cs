using UserManagement.Domain;
using System.Collections.Generic;
namespace UserManagement.Repository
{
    public interface IRepositorys<T> where T:BaseEntity //generic constraint
    {
         IEnumerable<T> GetAll();
        T Get(long id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}