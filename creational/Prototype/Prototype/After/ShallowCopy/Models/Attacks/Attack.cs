namespace Prototype.After.ShallowCopy.Models.Attacks
{
    public class Attack
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public override string ToString()
        {
            return $"[Name: {Name}, Damage: {Damage}]";
        }
    }
}
