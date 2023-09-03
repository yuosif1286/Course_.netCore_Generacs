// See https://aka.ms/new-console-template for more information
//good work

using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.RepositryManagment;

var employeeRepo = new SqlRepository<Employee>(new AppDbContext());

AddEmployee(employeeRepo);

GetEmployeeById(employeeRepo);

var orginRepo = new ListRepository<Orginization>();

AddOrgin(orginRepo);

Console.ReadLine();

static void AddEmployee(IRepository<Employee> employeeRepo)
{
    employeeRepo.Add(new Employee { FirstName = "yoyo" });

    employeeRepo.Add(new Employee { FirstName = "ali" });
    employeeRepo.Add(new Employee { FirstName = "moshtack" });
}

static void AddOrgin(IRepository<Orginization> orginRepo)
{
    orginRepo.Add(new Orginization { Name = "Alkafeel" });

    orginRepo.Add(new Orginization { Name = "goldenCastl" });
    orginRepo.Add(new Orginization { Name = "good" });

    orginRepo.Save();
}

static void GetEmployeeById(IRepository<Employee> employeeRepo)
{
    var employee = employeeRepo.GetById(2);

    Console.WriteLine($"employee id:2 , first name is {employee.FirstName}");
}