// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.RepositryManagment;

var employeeRepo = new EmployeeRepositry();

employeeRepo.Add(new Employee { FirstName = "yoyo" });

employeeRepo.Add(new Employee { FirstName = "ali" });
employeeRepo.Add(new Employee { FirstName = "moshtack" });

Console.ReadLine();