﻿// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public class GeneracRepositry<T /*,Tkey*/> where T : class, IEntityBase<int>
{
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
    }

    public void Remove(T item) => _items.Remove(item);
    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}
