using Prototype.After.DeepCopy.Models.Attacks;

namespace Prototype.After.DeepCopy.Models.Characters
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
            var mage = new Mage(this);
            mage.Attack = mage.Attack.Clone();

            return mage;
        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Mana: {Mana}");
        }
    }
}
