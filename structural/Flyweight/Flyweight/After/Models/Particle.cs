namespace Flyweight.After.Models
{
    public class Particle
    {
        private FlyweightParticle _flyweightParticle { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int Speed { get; set; }

        public Particle(string name, string sprite, string color, int coordinateX, int coordinateY, int speed)
        {
            _flyweightParticle = FlyweightParticleFactory.GetFlyweightParticle(name, sprite, color);
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Speed = speed;
        }

        public void Draw()
        {
            _flyweightParticle.Draw(CoordinateX, CoordinateY, Speed);
        }

        public void Move()
        {
            _flyweightParticle.Move(CoordinateX, CoordinateY, Speed);
        }
    }
}
