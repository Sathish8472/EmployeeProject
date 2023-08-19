// See https://aka.ms/new-console-template for more information

using EmployeeProject;

Console.WriteLine("Hello, World!");
IEmployee silverEmployee = new SilverEmployee();

Employee employee = new Employee(silverEmployee);
Console.WriteLine($"Silver empl 2 Salary: {employee.GetSalary()}");


IEmployee goldEmployee = new GoldEmployee();
Console.WriteLine($"Gold employee Salary: {goldEmployee.GetSalary()}");

Console.ReadLine();

