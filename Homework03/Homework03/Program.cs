using PetStore.Classes;


PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.AddPet(new Dog("Alfie", "Doberman", 3, true, "Bone"));
dogStore.AddPet(new Dog("Miki", "Labrador", 5, true, "Chicken"));


PetStore<Cat> catStore = new PetStore<Cat>();
catStore.AddPet(new Cat("Chaki", "Orange", 2, true, 9));
catStore.AddPet(new Cat("Paki", "Siamska", 4, false, 8));


PetStore<Fish> fishStore = new PetStore<Fish>();
fishStore.AddPet(new Fish("Nemo", "Nemo", 1, "Orange", "Small"));
fishStore.AddPet(new Fish("Branko", "Krap", 2, "Grey", "Big"));


dogStore.BuyPet("Miki");
catStore.BuyPet("Chaki");


Console.WriteLine("\nRemaining Dogs:");
PetStore<Dog>.PrintPets(dogStore.pets);

Console.WriteLine("\nRemaining Cats:");
PetStore<Cat>.PrintPets(catStore.pets);

Console.WriteLine("\nAll Fish:");
PetStore<Fish>.PrintPets(fishStore.pets);