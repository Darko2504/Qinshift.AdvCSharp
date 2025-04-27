

namespace Qinshift.AdvCSharp.Homework01.Classes
{
     public class Programmer : Employee
    {
        public double PayPerHour { get; set; }
        public double HoursWorked { get; set; }
        public Programmer(string firstName, string lastName, int age, double payPerHour, double hoursWorked)
                         : base(firstName, lastName, age)
        {
            PayPerHour = payPerHour;
            HoursWorked = hoursWorked;
        }
        public override double CalculateSalary()
        {
            return PayPerHour * HoursWorked;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"The employee {FirstName} {LastName} that is {Age} years old has worked {HoursWorked} hours this month.");
        }
    }
}
