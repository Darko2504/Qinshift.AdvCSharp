using Qinshift.AdvCSharp.Homework01.Classes;

#region FirstTask
WebPage web = new WebPage("Hello there huys. How are you today? Today is a sunny day and we gonna have fun!");
web.Search("today");
Console.WriteLine($"Searching the word 'today' in the sentence: \n{web.Text}");
Console.WriteLine(web.Search("today"));
Document doc = new Document("Qinshift academy is one of the best academies in the city!");
doc.Search("academy");
Console.WriteLine($"Searching the word 'academy' in the sentence :\n{doc.Text}");
Console.WriteLine(doc.Search("academy"));
Console.ReadLine();
#endregion

#region SecondTask
Console.Clear();
Console.WriteLine("Please enter first side for a rectangle: ");
double firstSideRectangle = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second side for a rectangle");
double secondSideRectangle = double.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle(firstSideRectangle, secondSideRectangle);
Console.WriteLine($"Rectangle Area is: {rectangle.GetArea()}");

Console.WriteLine("Please enter the radius for a circle");
double radiusCircle = double.Parse(Console.ReadLine());
Circle circle = new Circle(radiusCircle);
Console.WriteLine($"Circle Area: {circle.GetArea()}");

Console.WriteLine("Please enter the base of a triangle");
double baseTriangle = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of a triangle");
double heightTriangle = double.Parse(Console.ReadLine());
Triangle triangle = new Triangle(baseTriangle, heightTriangle);
Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
Console.ReadLine();
#endregion

#region ThirdTask
Console.Clear();
Console.WriteLine("Enter three sides of the triangle");
double firstSide = double.Parse(Console.ReadLine());
double secondSide = double.Parse(Console.ReadLine());
double thirdSide = double.Parse(Console.ReadLine());
Console.WriteLine("Enter base length for the triangle:");
double baseLength = double.Parse(Console.ReadLine());
Console.WriteLine("Enter height for the triangle");
double heightTriangleSecond = double.Parse(Console.ReadLine());
TriangleSecond triangleSecond = new TriangleSecond(baseLength, heightTriangleSecond, firstSide, secondSide, thirdSide);
Console.WriteLine($"The triangle area is: {triangleSecond.CalculateArea()}");
Console.WriteLine($"The triangle Peremiter is: {triangleSecond.CalculatePerimeter()}");


Console.WriteLine("Enter the circle radius");
double radius = double.Parse(Console.ReadLine());
CircleSecond circleSecond = new CircleSecond(radius);
Console.WriteLine($"The circle area is: {circleSecond.CalculateArea()}");
Console.WriteLine($"The circle peremiter is: {circleSecond.CalculatePerimeter()}");
Console.ReadLine();

#endregion

#region FourthTask
Console.Clear();
Manager manager = new Manager("Darko", "Milanovski", 24, 2250);
Console.WriteLine("The manager salary is:");
Console.WriteLine(manager.CalculateSalary()); ;
manager.GetInfo();

Programmer programmer = new Programmer("Angel", "Krsteveski", 17, 16, 160);
Console.WriteLine("The programmer salary is:");
Console.WriteLine(programmer.CalculateSalary());
programmer.GetInfo();

#endregion