using Homework05.Task2;

void HandleRestrictedUser(string userName)
{
    Console.WriteLine($"{userName} Users Found. Sending Email to Administration.");
    Console.WriteLine("Email Sent.");
    Console.WriteLine("Warning Alarm Started.");
    Console.WriteLine("Logging out.");
}

OnlineClass onlineClass = new OnlineClass();

onlineClass.OnRestrictedUser += HandleRestrictedUser;

Console.Write("Enter your name: ");
string name = Console.ReadLine();

onlineClass.LogIn(name);

onlineClass.OnRestrictedUser -= HandleRestrictedUser;