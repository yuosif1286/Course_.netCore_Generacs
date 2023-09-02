// See https://aka.ms/new-console-template for more information

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public class GeneracRepositryWithRemove<T>:GeneracRepositry<T>
{
    public void Remove(T item) => Items.Remove(item);
}