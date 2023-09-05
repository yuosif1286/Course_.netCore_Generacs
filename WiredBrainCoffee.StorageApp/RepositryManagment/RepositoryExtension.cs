using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public static class RepositoryExtension
{
   public static void AddBatch<T>(this IWriteRepositery<T> repo, T[] items)
        where T: IEntityBase
    {
        foreach (var item in items)
        {
            repo.Add(item);
        }
        repo.Save();
    }
}