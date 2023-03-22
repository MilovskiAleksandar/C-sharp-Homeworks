using EmployeeApp.Domain.Enum;
using EmployeeApp.Domain.Models;

Employee employee = new Employee("John", "Johnsky", Role.Other, 600);
employee.PrintInfo();
double employeeSalary = employee.GetSalary();
Console.WriteLine(employeeSalary);

Manager manager = new Manager("Bob", "Bobsky", Role.Manager, 1000);
manager.PrintInfo(); //inherited from Employee
manager.AddBonus(100);
double managerSalary = manager.GetSalary();
Console.WriteLine(managerSalary);

SalesPerson salesPerson = new SalesPerson("Kate", "Katesky", 500);
salesPerson.PrintInfo();
salesPerson.AddSuccessRevenue(2000);
Console.WriteLine(salesPerson.GetSalary());

//inicializirav Salary na 0 zatoa sto neznaev kako poinaku da go sredam :)
Contractor contractor = new Contractor("Aleksandar", "Milovski", Role.Contractor,0, 150, 10, manager); 
contractor.CurrentPosition();
double salaryContractor = contractor.GetSalary();
Console.WriteLine(salaryContractor);

CEO ceo = new CEO("Marko", "Markovski", Role.CEO, 1500, 20);
ceo.PrintInfo();
ceo.AddSharesPrice(100);
Console.WriteLine("Salary of CEO is: " + ceo.GetSalary());

//Make an array called Company with 2 contractors, 2 managers and 1 salesPerson
//Create a new instance of CEO and call:
//ceoName.PrintInfo(), ceoName.PrintEmployees() and ceoName.GetSalary() to check if everything is working.
List<Employee> company = new List<Employee>()
{
    new Contractor("Aleksandar", "Milovski", Role.Contractor,0, 150, 10, manager),
    new Contractor("Rick", "Ricky", Role.Contractor,0, 150, 10, manager),
    new Manager("Bob", "Bobert", Role.Manager, 1000),
    new Manager("Mona", "Lisa", Role.Manager, 1000),
    new SalesPerson("Lea", "Leova", 500)
};

ceo.PrintEmployees(company);