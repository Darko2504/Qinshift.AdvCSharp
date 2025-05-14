using Exercise01;

List<Dog> dogs = new List<Dog>()
{
    new Dog("Charlie", "Black", 3, Race.Collie), // 0
    new Dog("Buddy", "Brown", 1, Race.Doberman),
    new Dog("Max", "Olive", 1, Race.Plott),
    new Dog("Archie", "Black", 2, Race.Mutt),
    new Dog("Oscar", "White", 1, Race.Mudi),
    new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
    new Dog("Ollie", "Silver", 4, Race.Dalmatian),
    new Dog("Bailey", "White", 4, Race.Pointer),
    new Dog("Frankie", "Gray", 2, Race.Pug),
    new Dog("Jack", "Black", 5, Race.Dalmatian),
    new Dog("Chanel", "Black", 1, Race.Pug), // 10
    new Dog("Henry", "White", 7, Race.Plott),
    new Dog("Bo", "Maroon", 1, Race.Boxer),
    new Dog("Scout", "Olive", 2, Race.Boxer),
    new Dog("Ellie", "Brown", 6, Race.Doberman),
    new Dog("Hank", "Silver", 2, Race.Collie), // 15
    new Dog("Shadow", "Silver", 3, Race.Mudi),
    new Dog("Diesel", "Brown", 4, Race.Bulldog),
    new Dog("Abby", "Black", 1, Race.Dalmatian),
    new Dog("Trixie", "White", 8, Race.Pointer), // 19
};

List<Person> people = new List<Person>()
{
    new Person("Nathanael", "Holt", 20, Job.Choreographer),
    new Person("Rick", "Chapman", 35, Job.Dentist),
    new Person("Oswaldo", "Wilson", 19, Job.Developer),
    new Person("Kody", "Walton", 43, Job.Sculptor),
    new Person("Andreas", "Weeks", 17, Job.Developer),
    new Person("Kayla", "Douglas", 28, Job.Developer),
    new Person("Richie", "Campbell", 19, Job.Waiter),
    new Person("Soren", "Velasquez", 33, Job.Interpreter),
    new Person("August", "Rubio", 21, Job.Developer),
    new Person("Rocky", "Mcgee", 57, Job.Barber),
    new Person("Emerson", "Rollins", 42, Job.Choreographer),
    new Person("Everett", "Parks", 39, Job.Sculptor),
    new Person("Amelia", "Moody", 24, Job.Waiter)
    { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
    new Person("Emilie", "Horn", 16, Job.Waiter),
    new Person("Leroy", "Baker", 44, Job.Interpreter),
    new Person("Nathen", "Higgins", 60, Job.Archivist)
    { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
    new Person("Erin", "Rocha", 37, Job.Developer)
    { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
    new Person("Freddy", "Gordon", 26, Job.Sculptor)
    { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
    new Person("Valeria", "Reynolds", 26, Job.Dentist),
    new Person("Cristofer", "Stanley", 28, Job.Dentist)
    { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
};

Console.WriteLine("========================= 1 ===========================");
//1 baranje
//IEnumerable<Per> firstNameWithRSql = from p in people
//                                 where p.FirstName.StartsWith("R")
//                                 orderby p.Age
//                                 select p.FirstName;
                                 
List<string> firstNameWithR = people
       .OrderByDescending(x => x.Age)
       .Select(x => x.FirstName)
       .Where(x => x.StartsWith("R"))
       .ToList();
firstNameWithR.PrintSimple();

Console.WriteLine("====================== 2 ======================");

//2 baranje
List<string> brownDogsNamesOlderThanThree = dogs
        .Where(x => x.Color == "Brown" && x.Age > 3)
        .OrderBy(x => x.Age)
        .Select(x => $"{x.Name} {x.Age}")
        .ToList();
brownDogsNamesOlderThanThree.PrintSimple();
Console.WriteLine("==================== 3 =======================");

//3 baranje
List<string> personWithMoreThanTwoDogs = people
        .Where(x => x.Dogs.Count > 2)
        .OrderByDescending(x => x.FirstName)
        .Select(x => x.FirstName)
        .ToList();
personWithMoreThanTwoDogs.PrintSimple();
Console.WriteLine("====================== 4 ======================");

//4 baranje
List<string> allFredysDogsNames = people
         .Single(x => x.FirstName == "Freddy").Dogs
         .Where(d => d.Age > 1)
         .Select(d => d.Name)
         .ToList();
allFredysDogsNames.PrintSimple();
Console.WriteLine("====================== 5 ======================");

//5 baranje
Dog nathensFirstDog = people
        .Single(x => x.FirstName == "Nathen").Dogs
        .First();
Console.WriteLine(nathensFirstDog.Name);
Console.WriteLine("======================= 6 =====================");

//6 baranje
List<string> dogOwners = new() { "Cristofer", "Freddy", "Erin", "Amelia" };
List<string> dogOwnerNames = people
    .Where(x => dogOwners.Contains(x.FirstName))
    .SelectMany(x => x.Dogs)
    .Where(d => d.Color.ToLower() == "white")
    .OrderBy(d => d.Name)
    .Select(d => d.Name).ToList();
dogOwnerNames.PrintSimple();
