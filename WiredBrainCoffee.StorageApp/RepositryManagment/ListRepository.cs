﻿// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;


public class ListRepository<T /*,Tkey*/> :IRepository<T> where T : class, IEntityBase
{
    public event Action<T>? ItemAdded;
    //protected Tkey? key { get; set; }

    private readonly List<T> _items=new ();
    
    public  T GetById(int id)
    {
        return _items.Single(x => x.Id == id);
    }
    

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
        ItemAdded?.Invoke(item);
    }

    public void Remove(T item) => _items.Remove(item);
    public void Save()
    {
     // save already in list<T>
    }

    public  IEnumerable<T> GetAll() => _items.OrderBy(item=>item.Id).ToList();

}