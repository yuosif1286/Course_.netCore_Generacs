// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public class GeneracRepositry<T>
{

    protected readonly List<T> Items=new ();

   public void Add(T item)
    {
        Items.Add (item); 
    }

    public void Save()
    {
        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }
    }
}
