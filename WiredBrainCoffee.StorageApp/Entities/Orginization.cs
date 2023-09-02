namespace WiredBrainCoffee.StorageApp.Entities;

public class Orginization:EntityBase<int>
{
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"id:{Id} , firstname:{Name}";
    }
}
