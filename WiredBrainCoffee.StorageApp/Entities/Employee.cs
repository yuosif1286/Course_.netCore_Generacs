// See https://aka.ms/new-console-template for more information
class Employee 
{
    public  int id { get; set; }
    public  string FirstName { get; set; }

    public override string ToString() => $"Id:{id},firstname:{FirstName} ";
}