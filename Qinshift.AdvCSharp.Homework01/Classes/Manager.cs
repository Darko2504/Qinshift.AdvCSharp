

namespace Qinshift.AdvCSharp.Homework01.Classes
{
    public class Manager : Employee
    {
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public Manager(string firstName, string lastName, int age, double salary)
            : base(firstName, lastName, age)
        {
            Salary = salary;
            
        }

        public override double CalculateSalary()
        {
            double bonus = Salary * 0.50;
            return Salary + bonus;
        }

        public override void GetInfo() 
        {
            Console.WriteLine($"The manager {FirstName} {LastName} with {Age} years of age is getting {Salary} before bonuses!");
        }
    }
}
