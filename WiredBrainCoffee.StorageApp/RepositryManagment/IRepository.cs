using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment
{
    public interface IRepository<T> where T :  IEntityBase<int>
    {
        void Add(T item);
        T? GetById(int id);
        void Remove(T item);
        void Save();
    }
}