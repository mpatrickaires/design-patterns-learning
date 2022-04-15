using Prototype.After.ShallowCopy.Models.Attacks;

namespace Prototype.After.ShallowCopy.Models.Characters
{
    public class Mage : Character
    {
        public int Mana { get; set; }

        public Mage(int health, int speed, Attack attack, int mana) : base(health, speed, attack)
        {
            Mana = mana;
        }

        public Mage(Mage mage) : base(mage)
        {
            Mana = mage.Mana;
        }

        public override Character Clone()
        {
            return new Mage(this);
        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Mana: {Mana}");
        }
    }
}
