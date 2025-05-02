#region FirstTask
using Homeowk02.FirstTaskClasses;
using Homeowk02.SecondTaskClasses;

Console.WriteLine("Enter id. 1/2/3");
int idChoice = int.Parse(Console.ReadLine());
User userById = UserDb.FindUserById(idChoice);

if (userById != null)
{
    Console.WriteLine("Id:");
    Console.WriteLine(userById.Id);
    Console.WriteLine("Name:");
    Console.WriteLine(userById.Name);
    Console.WriteLine("Age");
    Console.WriteLine(userById.Age);
}
else
{
    Console.WriteLine("Not a user with that id found");
}
Console.ReadLine();


Console.Clear();
Console.WriteLine("Enter a name (Darko, Martin, Slave)");
string nameChoice = Console.ReadLine();
User userByName = UserDb.FindUserByName(nameChoice);

if(nameChoice != null)
{
    Console.WriteLine("Id:");
    Console.WriteLine(userByName.Id);
    Console.WriteLine("Name:");
    Console.WriteLine(userByName.Name);
    Console.WriteLine("Age");
    Console.WriteLine(userByName.Age);
}
else
{
    Console.WriteLine("Not a user with such name exist!");
}
Console.ReadLine();


Console.Clear();
Console.WriteLine("Enter age (24, 31, 21)");
int ageChoice = int.Parse(Console.ReadLine());
User userByAge = UserDb.FindUserByAge(ageChoice);

if (userByAge != null)
{
    Console.WriteLine("Id:");
    Console.WriteLine(userByAge.Id);
    Console.WriteLine("Name:");
    Console.WriteLine(userByAge.Name);
    Console.WriteLine("Age");
    Console.WriteLine(userByAge.Age);
}
else
{
    Console.WriteLine("Not a user with that age exist!");
}
Console.ReadLine();
Console.Clear();

#endregion

#region SecondTask
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

#endregion