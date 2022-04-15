namespace Prototype.After.DeepCopy.Models.Attacks
{
    public class Attack
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Attack() { }
        public Attack(Attack attack)
        {
            Name = attack.Name;
            Damage = attack.Damage;
        }

        public Attack Clone()
        {
            return new Attack(this);
        }

        public override string ToString()
        {
            return $"[Name: {Name}, Damage: {Damage}]";
        }
    }
}
