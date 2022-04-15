using Prototype.After.DeepCopy.Models.Attacks;

namespace Prototype.After.DeepCopy.Models.Characters
{
    public class Knight : Character
    {
        public int Armor { get; set; }

        public Knight(int health, int speed, Attack attack, int armor) : base(health, speed, attack)
        {
            Armor = armor;
        }

        public Knight(Knight knight) : base(knight)
        {
            Armor = knight.Armor;
        }

        public override Character Clone()
        {
            var knight = new Knight(this);
            knight.Attack = knight.Attack.Clone();

            return knight;
        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Armor: {Armor}");
        }
    }
}
