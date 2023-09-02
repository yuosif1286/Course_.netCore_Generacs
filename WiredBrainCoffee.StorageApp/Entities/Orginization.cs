namespace WiredBrainCoffee.StorageApp.Entities;

public class Orginization
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"id:{Id} , firstname:{Name}";
    }
}