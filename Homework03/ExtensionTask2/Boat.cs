

namespace ExtensionTask2
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("i am a boat and i dont have wheels");
        }
        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
    }
}
