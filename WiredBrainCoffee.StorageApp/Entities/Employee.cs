namespace WiredBrainCoffee.StorageApp.Entities;

public class Employee:EntityBase<int>
{
    public string? FirstName { get; set; }

    public override string ToString()
    {
        return $"id:{Id} , firstname:{FirstName}";
    }
}
