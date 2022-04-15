namespace Prototype.Before.Models.Characters
{
    public class Mage : Character
    {
        public int Mana { get; set; }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Mana: {Mana}");
        }
    }
}
