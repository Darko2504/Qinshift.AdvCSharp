

namespace ExtensionTask2
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a car and i drive on 4 wheels!");
        }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
