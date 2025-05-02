
using System.Reflection.Metadata.Ecma335;

namespace PetStore.Classes
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public Dog(string name, string type, int age , bool goodBoy, string favoriteFood)
                   : base(name, type, age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The dog {Type} {Name} which is {Age} years of age is a good boy :{GoodBoy} and it's favorite food is {FavoriteFood}");
        }
    }
}
