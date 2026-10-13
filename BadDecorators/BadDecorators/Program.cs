namespace BadDecorators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player steve = new Player();
            Console.WriteLine(steve.GetSpeed());
            steve.hasSpeedPotion = true;
            steve.hasSlownessPotion = true;
            Console.WriteLine(steve.GetSpeed());
        }
    }
}
