using Prototype.After.DeepCopy.Models.Attacks;

namespace Prototype.After.DeepCopy.Models.Characters
{
    public abstract class Character
    {
        private int Health;
        public int Speed { get; set; }
        public Attack Attack { get; set; }

        protected Character(int health, int speed, Attack attack)
        {
            Health = health;
            Speed = speed;
            Attack = attack;
        }

        public Character(Character character)
        {
            Health = character.Health;
            Speed = character.Speed;
            Attack = character.Attack;
        }

        public abstract Character Clone();

        public virtual void Details()
        {
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Attack: {Attack}");
        }
    }
}
