// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public class GeneracRepositry<T/*,Tkey*/> where T :EntityBase<int>
{
    //protected Tkey? key { get; set; }

    private readonly List<T> Items=new ();

    public  T GetById(int Id) => Items.Single(x => x.Id == Id);
    public void Add(T item)
    {
        item.Id = Items.Count + 1;
        Items.Add(item);
    }

    public void Remove(T item) => Items.Remove(item);
    public void Save()
    {
        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }
    }
}
