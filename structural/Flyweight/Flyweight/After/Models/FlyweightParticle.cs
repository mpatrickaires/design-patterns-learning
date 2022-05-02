namespace Flyweight.After.Models
{
    public class FlyweightParticle
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Sprite { get; }
        public string Color { get; }

        public FlyweightParticle(string name, string sprite, string color)
        {
            Id = Guid.NewGuid();
            Name = name;
            Sprite = sprite;
            Color = color;
        }

        public bool Equals(string name, string sprite, string color)
        {
            return Name == name &&
                Sprite == sprite &&
                Color == color;
        }

        public void Draw(int coordinateX, int coordinateY, int speed)
        {
            Console.WriteLine($"Intrinsic State (immutable):");
            Console.WriteLine($"   - Id: {Id}");
            Console.WriteLine($"   - Name: {Name}");
            Console.WriteLine($"   - Sprite: {Sprite}");
            Console.WriteLine($"   - Color: {Color}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Coordinates: ({coordinateX}, {coordinateY})");
            Console.WriteLine();
        }

        public void Move(int coordinateX, int coordinateY, int speed)
        {
            Console.WriteLine($"Moving to coordinates ({coordinateX}, {coordinateY}) at speed of {speed} m/s");
            Console.WriteLine();
        }
    }
}
