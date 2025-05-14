
using System.Collections.Generic;
using OfficialHomework;

//// 1 baranje
//List<Car> allCarsFromEurope = CarsData.Cars
//                        .Where(x => x.Origin == "Europe").ToList();
//allCarsFromEurope.PrintEntities();

//// 2 baranje
//List<int> uniqueCylinderValues = CarsData.Cars
//                         .Select(x => x.Cylinders)
//                         .Distinct()
//                         .ToList();
//uniqueCylinderValues.PrintSimple();

////3 baranje
//List<string> allCarsNamesConverted = CarsData.Cars
//                          .Select(x => x.Model.ToUpper())
//                          .ToList();
//allCarsNamesConverted.PrintSimple();

////4 baranje
//bool aboveThreeHundredHp = CarsData.Cars
//                          .Any(x => x.HorsePower > 300);
//Console.WriteLine(aboveThreeHundredHp);

////5 baranje
//Car highestHorsepower = CarsData.Cars
//                        .OrderByDescending(x => x.HorsePower)
//                        .First();
//Console.WriteLine(highestHorsepower.Model);

//// 6 baranje
//List<Car> allChevroletCars = CarsData.Cars
//                        .OrderByDescending(x => x.Weight)
//                        .Where(x => x.Model.StartsWith("Chevrolet"))
//                        .ToList();
//allChevroletCars.PrintEntities();

//// 7 baranje
//Car longestName = CarsData.Cars
//            .OrderByDescending(x => x.Model.Length)
//            .First();
//Console.WriteLine(longestName.Model);

////8 baranje


////9 baranje
//List<Car> top5Hp = CarsData.Cars
//              .OrderByDescending(x => x.HorsePower)
//              .Take(5)
//              .ToList();
//top5Hp.PrintEntities();

////10 baranje
//Car highestAcc = CarsData.Cars
//               .OrderByDescending(x => x.AccelerationTime)
//               .First();
//Console.WriteLine(highestAcc.Model);

////11 baranje
//List<string> greaterThan200Hp = CarsData.Cars
//            .Where(x => x.HorsePower > 200)
//            .Select(x => $"{x.Model} {x.HorsePower} hp")
//            .ToList();

//greaterThan200Hp.PrintSimple();

////12 baranje
//List<string> uniqueOriginsOfCars = CarsData.Cars
//             .Select(x => x.Origin)
//             .Distinct()
//             .ToList();
//uniqueOriginsOfCars.PrintSimple();

////13 baranje
//List<string> moreThan4Cilinders = CarsData.Cars
//            .Where(x => x.Cylinders >= 4)
//            .OrderBy(x => x.Origin)
//            .OrderBy(x => x.HorsePower)
//            .Select(x => x.Model)
//            .ToList();
//moreThan4Cilinders.PrintSimple();

//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine(" ");

////14 baranje
//List<Car> moreThan6Cilinders = CarsData.Cars
//            .Where(x => x.Cylinders > 6)
//            .Concat(
//            CarsData.Cars.Where(y => y.Cylinders == 4 && y.HorsePower > 110.0))
//            .ToList();
//moreThan6Cilinders.PrintEntities();

////15 baranje
//List<Car> moreThan200Hp = CarsData.Cars
//            .Where(x => x.HorsePower > 200)
//            .ToList();

//double minimum = moreThan200Hp.Min(x => x.MilesPerGalon) ;
//double maximum = moreThan200Hp.Max(x => x.MilesPerGalon);
//double average = moreThan200Hp.Average(x => x.MilesPerGalon);

//Console.WriteLine($"The minimum miles per galon car is {minimum}");
//Console.WriteLine($"The maximum miles per galon car is {maximum}");
//Console.WriteLine($"The average miles per galon car is {average}");

////16 baranje
//List<string> smh = CarsData.Cars
//        .OrderByDescending(x => x.Model)
//        .Where(x => x.Model.StartsWith("M") && x.HorsePower > 120)
//        .Select(x => x.Model)
//        .ToList();
//smh.PrintSimple();

////17 baranje
//List<Car> smh2 = CarsData.Cars
//        .Where(x => x.Cylinders > 4 && x.HorsePower > 200)
//        .OrderBy(x => x.AccelerationTime)
//        .Take(5)
//        .ToList();
//smh2.PrintEntities();
//Console.ReadLine();

// 1 baranje
List<Car> allCarsFromEurope = CarsData.Cars
                        .Where(x => x.Origin == "Europe").ToList();
Console.WriteLine("All cars from Europe");
allCarsFromEurope.PrintEntities();

//2 baranje
List<Car> moreThan6Cilinders = CarsData.Cars
            .Where(x => x.Cylinders > 6)
            .Concat(
            CarsData.Cars.Where(y => y.Cylinders == 4 && y.HorsePower > 110.0))
            .ToList();
Console.WriteLine("More than 6 cylinders");
moreThan6Cilinders.PrintEntities();

//3 baranje

Console.WriteLine("Cars by origin : ");
var carCountByOrigin = CarsData.Cars
    .GroupBy(x => x.Origin)
    .Select(x => (Origin: x.Key, Count: x.Count()));

foreach (var originGroup in carCountByOrigin)
{
    Console.WriteLine($"{originGroup.Origin} {originGroup.Count} models");
}


//4 baranje
Console.WriteLine("Max min and avg mpg");
List<Car> moreThan200Hp = CarsData.Cars
            .Where(x => x.HorsePower > 200)
            .ToList();

double minimum = moreThan200Hp.Min(x => x.MilesPerGalon );
double maximum = moreThan200Hp.Max(x => x.MilesPerGalon);
double average = moreThan200Hp.Average(x => x.MilesPerGalon);

Console.WriteLine($"The minimum miles per galon on a car is {minimum} mpg");
Console.WriteLine($"The maximum miles per galon on a car is {maximum} mpg");
Console.WriteLine($"The average miles per galon on a car is {average} mpg");


//5 baranje
Console.WriteLine("Fastest 3 accelerating cars");

List < Car > fastestAccCars = CarsData.Cars
            .OrderBy(x => x.AccelerationTime)
            .Take(3)
            .ToList();

fastestAccCars.PrintEntities();

foreach(Car fastestCar in fastestAccCars)
{
    Console.WriteLine(fastestCar.Model);
}


//6 baranje

double totalWeight = CarsData.Cars
            .Where(x => x.Cylinders > 6)
            .Sum(x => x.Weight);
Console.WriteLine($"the total weight of cars with more than 6 cylinders is {totalWeight}");



//7 baranje e istoto kako 6

//8 baranje
//Find the average MilesPerGalon for cars with even number of cylinders:
double avgMilesEvenCyl = CarsData.Cars
                .Where(x => x.Cylinders % 2 == 0)
                .Average(x => x.MilesPerGalon);
Console.WriteLine($"The average mpg for cars with even number of cylinders is {avgMilesEvenCyl}");       

Console.ReadLine();