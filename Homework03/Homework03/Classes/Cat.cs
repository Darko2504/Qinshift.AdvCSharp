

namespace PetStore.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, string type, int age, bool lazy, int livesLeft) 
                   : base(name,type, age)
            
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The cat {Type} {Name} which is {Age} years of age is lazy: {Lazy} and has {LivesLeft} lives left!");
        }
    }
}
