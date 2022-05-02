namespace Flyweight.After.Models
{
    public static class FlyweightParticleFactory
    {
        private static List<FlyweightParticle> _flyweightParticles = new List<FlyweightParticle>();

        public static FlyweightParticle GetFlyweightParticle(string name, string sprite, string color)
        {
            FlyweightParticle flyweightParticle = _flyweightParticles.FirstOrDefault(f => f.Equals(name, sprite, color));

            if (flyweightParticle == null)
            {
                flyweightParticle = new FlyweightParticle(name, sprite, color);
                _flyweightParticles.Add(flyweightParticle);
            }

            return flyweightParticle;
        }
    }
}
