// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.RepositryManagment;

public class EmployeeRepositry
{

    private readonly List<Employee> _employees=new ();

   public void Add(Employee employee)
    {
        _employees.Add (employee); 
    }

    public void Save()
    {
        foreach (Employee emp in _employees)
        {
            Console.WriteLine(_employees);
        }
    }
}
