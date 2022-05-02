namespace Flyweight.Before.Models
{
    public class Particle
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Sprite { get; }
        public string Color { get; }
        public int Speed { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Particle(string name, string sprite, string color, int speed, int coordinateX, int coordinateY)
        {
            Id = Guid.NewGuid();
            Name = name;
            Sprite = sprite;
            Color = color;
            Speed = speed;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        public void Draw()
        {
            Console.WriteLine($"Intrinsic State (immutable):");
            Console.WriteLine($"   - Id: {Id}");
            Console.WriteLine($"   - Name: {Name}");
            Console.WriteLine($"   - Sprite: {Sprite}");
            Console.WriteLine($"   - Color: {Color}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Coordinates: ({CoordinateX}, {CoordinateY})");
            Console.WriteLine();
        }

        public void Move()
        {
            Console.WriteLine($"Moving to coordinates ({CoordinateX}, {CoordinateY}) at speed of {Speed} m/s");
            Console.WriteLine();
        }
    }
}
