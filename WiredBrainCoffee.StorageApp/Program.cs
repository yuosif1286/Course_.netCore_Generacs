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

var orginRepo = new ListRepository<Organization>();

AddOrgin(orginRepo);

WriteAllInConsole(orginRepo);

static void AddEmployee(IRepository<Employee> employeeRepo)
{
    var employees = new[]
    {
        new Employee { FirstName = "yoyo" },
        new Employee { FirstName = "ali" },
        new Employee { FirstName = "moshtack" }
    };
    AddBatch<Employee>(employeeRepo,employees);
}

static void AddOrgin(IRepository<Organization> orginRepo)
{
    var oreginizations = new[]
    {
        new Organization { Name = "Alkafeel" },
        new Organization { Name = "goldenCastl" },
        new Organization { Name = "good" }
    };
    AddBatch(orginRepo, oreginizations);
    
}

static void AddBatch<T>(IWriteRepositery<T> repo, T[] items)
where T: IEntityBase
{
    foreach (var item in items)
    {
        repo.Add(item);
    }
    repo.Save();
}

static void GetEmployeeById(IRepository<Employee> employeeRepo)
{
    var employee = employeeRepo.GetById(2);

    Console.WriteLine($"employee id:2 , first name is {employee.FirstName}");
}
Console.ReadLine();