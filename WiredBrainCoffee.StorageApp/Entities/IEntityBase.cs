namespace WiredBrainCoffee.StorageApp.Entities;

public interface IEntityBase<K>
{
    K Id { get; set; }
}