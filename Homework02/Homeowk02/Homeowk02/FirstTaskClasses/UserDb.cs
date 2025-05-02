namespace Homeowk02.FirstTaskClasses
{
   static class UserDb
    {
        private static List<User> Users = new List<User>
    {
        new User(1, "Darko", 24),
        new User(2, "Martin", 31),
        new User(3, "Slave", 21)
    };
        public static User FindUserById(int id)
        {
            return Users.FirstOrDefault(u => u.Id == id);
        }

        public static User FindUserByName(string name)
        {
            return Users.FirstOrDefault(u => u.Name.Equals(name));
        }

        public static User FindUserByAge(int age)
        {
            return Users.FirstOrDefault(u => u.Age == age);
        }
    }
}
