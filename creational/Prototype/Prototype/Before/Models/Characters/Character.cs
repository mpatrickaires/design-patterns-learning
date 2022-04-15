using Prototype.Before.Models.Attacks;

namespace Prototype.Before.Models.Characters
{
    public abstract class Character
    {
        public int Health;
        public int Speed { get; set; }
        public Attack Attack { get; set; }

        public virtual void Details()
        {
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Attack: {Attack}");
        }
    }
}
