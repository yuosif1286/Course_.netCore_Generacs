namespace WiredBrainCoffee.StorageApp.Entities;


public class EntityBase<TKey>:IEntityBase<TKey>
{
    public TKey Id { get; set; }
}