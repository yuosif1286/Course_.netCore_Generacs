// See https://aka.ms/new-console-template for more information
//good work

using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.RepositryManagment;

var employeeRepo = new ListRepository<Employee>();

AddEmployee(employeeRepo);
AddManager(employeeRepo);



void AddManager(IWriteRepositery<Manager> managerRepo)
{
    managerRepo.Add(new Manager() { FirstName="zainab"});
    managerRepo.Add(new Manager() { FirstName = "fofo" });
    managerRepo.Save();
}

GetEmployeeById(employeeRepo);
WriteAllInConsole(employeeRepo);

static  void WriteAllInConsole(IReadRepository<EntityBase> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

var orginRepo = new ListRepository<Orginization>();

AddOrgin(orginRepo);

WriteAllInConsole(orginRepo);

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
Console.ReadLine();