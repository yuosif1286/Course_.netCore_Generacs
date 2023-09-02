// See https://aka.ms/new-console-template for more information
//good work
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.RepositryManagment;

var employeeRepo = new GeneracRepositry<Employee>();

AddEmployee(employeeRepo);

GetEmployeeById(employeeRepo);

var orginRepo = new GeneracRepositry<Orginization>();

AddOrgin(orginRepo);

Console.ReadLine();

static void AddEmployee(GeneracRepositry<Employee> employeeRepo)
{
    employeeRepo.Add(new Employee { FirstName = "yoyo" });

    employeeRepo.Add(new Employee { FirstName = "ali" });
    employeeRepo.Add(new Employee { FirstName = "moshtack" });
}

static void AddOrgin(GeneracRepositry<Orginization> orginRepo)
{
    orginRepo.Add(new Orginization { Name = "Alkafeel" });

    orginRepo.Add(new Orginization { Name = "goldenCastl" });
    orginRepo.Add(new Orginization { Name = "good" });

    orginRepo.Save();
}

static void GetEmployeeById(GeneracRepositry<Employee> employeeRepo)
{
    var employee = employeeRepo.GetById(2);

    Console.WriteLine($"employee id:2 , first name is {employee.FirstName}");
}