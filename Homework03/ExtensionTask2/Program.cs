
using ExtensionTask2;
using System.Numerics;

Car car = new Car();
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane plane = new Airplane();

car.DisplayInfo();
car.Drive();
motorBike.DisplayInfo();
motorBike.Wheelie();
boat.DisplayInfo();
boat.Sail();
plane.DisplayInfo();
plane.Fly();