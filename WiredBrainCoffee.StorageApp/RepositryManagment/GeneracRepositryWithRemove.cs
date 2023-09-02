// See https://aka.ms/new-console-template for more information

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public class GeneracRepositryWithRemove<T,TK>:GeneracRepositry<T,TK>
{
    public void Remove(T item) => Items.Remove(item);
}