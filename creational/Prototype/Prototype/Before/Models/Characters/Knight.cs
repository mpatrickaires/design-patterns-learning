namespace Prototype.Before.Models.Characters
{
    public class Knight : Character
    {
        public int Armor { get; set; }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Armor: {Armor}");
        }
    }
}
