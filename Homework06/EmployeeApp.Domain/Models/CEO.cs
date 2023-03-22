//Task 3
using EmployeeApp.Domain.Enum;

namespace EmployeeApp.Domain.Models
{
    public class CEO : Employee
    {
        //Make a new class CEO that inherits from Employee that will have a property Employees
        //( an array of Employees), Shares property ( int ), SharesPrice ( double )
        public List<Employee> Employees { get; set; }
        public int Shares { get; set; }

        //The shares price should not be accessed from outside of the class
        private double SharesPrice { get; set; }

        

        public CEO(string firstName, string lastName, Role role, double salary,int shares) 
            : base(firstName, lastName, role, salary)
        {
            Employees = new List<Employee>();
            Shares = shares;
        }

        //There should be a method called AddSharesPrice() that will accept a double number and it will change the SharesPrice.
        //This is the only way to change SharesPrice
        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
        }

        //The CEO should have a method called PrintEmployees() that will print all employees that work for his company.
        public void PrintEmployees(List<Employee> company)
        {
            Console.WriteLine("Employees for this company are: ");
            foreach(Employee emp in company)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }

        //The CEO should override the GetSalary method to return Salary + Shares * SharesPrice
        public override double GetSalary()
        {   
            return Salary + Shares * SharesPrice;
        }
    }
}
