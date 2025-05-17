

namespace Homework05.Task2
{
    public delegate void RestrictedUser(string username);
    public class OnlineClass
    {
        public event RestrictedUser OnRestrictedUser;

        public List<string> RestrictedUsersList = new List<string> { "Bob", "Jill", "Alice" };

        public void LogIn(string username)
        {
            if (RestrictedUsersList.Contains(username))
            {
                OnRestrictedUser.Invoke(username);
            }
            else
            {
                Console.WriteLine($"Welcome {username}.");
            }
        }

    }
}
