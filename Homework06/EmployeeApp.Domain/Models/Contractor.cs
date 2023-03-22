//Task 2
//Extend the exercise for Employees. Add a class called Contractor that inherits from Employee.
using EmployeeApp.Domain.Enum;
namespace EmployeeApp.Domain.Models
{
    public class Contractor : Employee
    {
        //The employee should have properties: WorkHours(double ), PayPerHour(int ) and Responsible(Manager (object )).
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, Role role, double salary, double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, role, salary)
        {
            
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
                
        }
        //The GetSalary method should be overridden to return WorkHours* PayPerHour and also change the Salary property to that amount
        public override double GetSalary()
        {
            double salary = WorkHours * PayPerHour;
            Salary = salary;
            return salary;

            //return Salary += WorkHours * PayPerHour;
        }

        //A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor
        public void CurrentPosition()
        {
            Console.WriteLine($"Responsible for {FirstName}  is department {Responsible.Role}, with the Name: {Responsible.FirstName}");
        }

    }
}
