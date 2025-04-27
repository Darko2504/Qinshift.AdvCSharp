
namespace Qinshift.AdvCSharp.Homework01.Classes
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set;}
        public Employee(string firstName, string lastName, int age )
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public abstract double CalculateSalary();
        public abstract void GetInfo();
    }
}
