

namespace PetStore.Classes
{
   public class PetStore<T> where T : Pet
    {
        public List<T> pets = new List<T>();
        public void AddPet(T pet)
        {
            pets.Add(pet);
        }
        public static void PrintPets<U>(List<U> pets) where U : Pet
        {
            foreach (U pet in pets)
            {
                pet.PrintInfo();
            }
        }
        public void BuyPet(string name)
        {
            T pet = pets.FirstOrDefault(p => p.Name == name);
            if (pet != null)
            {
                pets.Remove(pet);
                Console.WriteLine($"Successfully bought {pet.Type}: {pet.Name}");
            }
            else
            {
                Console.WriteLine($"Sorry, no pet named {name} was found.");
            }
        }
    }
}
