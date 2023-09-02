// See https://aka.ms/new-console-template for more information

using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.RepositryManagment;

var employeeRepo = new GeneracRepositryWithRemove<Employee>();

employeeRepo.Add(new Employee { FirstName = "yoyo" });

employeeRepo.Add(new Employee { FirstName = "ali" });
employeeRepo.Add(new Employee { FirstName = "moshtack" });



employeeRepo.Save();

var orginRepo = new GeneracRepositryWithRemove<Orginization>();

orginRepo.Add(new Orginization { Name = "Alkafeel" });

orginRepo.Add(new Orginization { Name = "goldenCastl" });
orginRepo.Add(new Orginization { Name = "good" });

orginRepo.Save();

Console.ReadLine();