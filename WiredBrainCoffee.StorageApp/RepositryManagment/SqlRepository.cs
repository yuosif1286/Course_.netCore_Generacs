using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment
{
    
    public delegate void ItemAdded<T>(T item);
    public class SqlRepository<T> : IRepository<T>
        where T : class, IEntityBase
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        private readonly ItemAdded<T>? _itemAddedCallback;

        public SqlRepository(DbContext dbContext,ItemAdded<T>? itemAddedCallback=null)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
            _itemAddedCallback = itemAddedCallback;
        }

        public T? GetById(int id) => _dbSet.Find(id);


        public void Add(T item)
        {
            _dbSet.Add(item);
            _itemAddedCallback?.Invoke(item);
        }


        public void Remove(T item) => _dbSet.Remove(item);
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public  IEnumerable<T> GetAll()
        {
            return  _dbSet.ToList();
        }
    }
}

