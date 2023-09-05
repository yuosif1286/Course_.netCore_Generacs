using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment
{
    public interface IWriteRepositery<in T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
    }
    public interface IRepository<T> :IReadRepository<T> , IWriteRepositery<T>
        where T :  EntityBase
    {
     
    }

   
}