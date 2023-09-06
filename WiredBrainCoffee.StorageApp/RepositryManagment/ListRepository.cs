// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;


public class ListRepository<T /*,Tkey*/> :IRepository<T> where T : class, IEntityBase
{
    private readonly Action<T>? _itemAddedCallback;
    //protected Tkey? key { get; set; }

    private readonly List<T> _items=new ();

    public ListRepository(Action<T>? itemAddedCallback=null)
    {
        _itemAddedCallback = itemAddedCallback;
    }
    public  T GetById(int id)
    {
        return _items.Single(x => x.Id == id);
    }
    

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
        _itemAddedCallback?.Invoke(item);
    }

    public void Remove(T item) => _items.Remove(item);
    public void Save()
    {
     // save already in list<T>
    }

    public  IEnumerable<T> GetAll() => _items.OrderBy(item=>item.Id).ToList();

}