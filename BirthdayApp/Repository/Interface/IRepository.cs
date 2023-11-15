
namespace BirthdayApp.Repository.Interface
{
    public interface IRepository<T>
    {
        T GetById(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        IEnumerable<T> GetAll();
    }
}
