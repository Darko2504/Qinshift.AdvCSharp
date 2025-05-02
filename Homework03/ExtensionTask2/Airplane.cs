

namespace ExtensionTask2
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("i am a plane and i have a couple of wheels");
        }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
