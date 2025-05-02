
namespace ExtensionTask2
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("i am a motorbike and i drive on 2 wheels");
        }
        public void Wheelie() 
        {
            Console.WriteLine("Driving on one wheel");        
        }
    }
}
