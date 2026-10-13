namespace Decorators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayer steve = new Player();
            Console.WriteLine(steve.GetSpeed());
            steve = new SlownessPotion(steve);
            steve = new SpeedPotion(steve);
            Console.WriteLine($"en multiplier på 1.2 ger en hastighet på : {steve.GetSpeed()}");
            //steve = new SlownessPotion(steve);
            Console.WriteLine($"0.67 multipler ger oss en hastighet på : {steve.GetSpeed()}");
        }
    }
}
