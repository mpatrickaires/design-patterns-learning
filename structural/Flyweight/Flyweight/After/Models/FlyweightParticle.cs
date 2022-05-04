namespace Flyweight.After.Models
{
    public class FlyweightParticle
    {
        private readonly Guid _id;
        private readonly string _name;
        private readonly string _sprite;
        private readonly string _color;
        public Guid Id => _id;
        public string Name => _name;
        public string Sprite => _sprite;
        public string Color => _color;

        public FlyweightParticle(string name, string sprite, string color)
        {
            _id = Guid.NewGuid();
            _name = name;
            _sprite = sprite;
            _color = color;
        }

        public bool Equals(string name, string sprite, string color)
        {
            return _name == name &&
                _sprite == sprite &&
                _color == color;
        }

        public void Draw(int coordinateX, int coordinateY, int speed)
        {
            Console.WriteLine($"Intrinsic State (immutable):");
            Console.WriteLine($"   - Id: {_id}");
            Console.WriteLine($"   - Name: {_name}");
            Console.WriteLine($"   - Sprite: {_sprite}");
            Console.WriteLine($"   - Color: {_color}");
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
