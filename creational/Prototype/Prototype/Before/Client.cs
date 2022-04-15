using Prototype.Before.Models.Attacks;
using Prototype.Before.Models.Characters;

/*
 * Without Prototype, if we wanted to make the copy of an object by getting all the values that are
 * already set, we need to first create a new object and then set the values of the original object
 * to all the fields that we want to be copied to the copy object, and then change what we may want in 
 * the object itself. This has many problems (like the high verbosity), but also a failure point  
 * if the class of the object has a private attribute, because it's impossible to access it directly 
 * from an outside class (in our example, the Client) to send to the copy object.
 * Another problem is that we can't take advantage of the abstraction due to some fields that may
 * only exist in the concret classes and that would not be accessible through the abstraction.
 */

namespace Prototype.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            // Here, we can't create the mageOriginal as an Character type due to the Mage class having
            // his own field (Mana), which would be inacessible by the Character.
            Mage mageOriginal = new Mage();
            mageOriginal.Health = 80;
            mageOriginal.Speed = 30;
            mageOriginal.Attack = new Attack { Name = "Fireball", Damage = 100 };
            mageOriginal.Mana = 60;

            var knightOriginal = new Knight();
            knightOriginal.Health = 160;
            knightOriginal.Speed = 20;
            knightOriginal.Attack = new Attack { Name = "Sword Attack", Damage = 80 };
            knightOriginal.Armor = 90;

            Mage mageCopy = new Mage();
            // In our other examples, Health is a private field, so it would be impossible to  
            // access it directly through the mageOriginal to pass it to the mageCopy.
            mageCopy.Health = mageOriginal.Health;
            mageCopy.Speed = mageOriginal.Speed;
            mageCopy.Mana = 80;
            mageCopy.Attack = mageOriginal.Attack;
            mageCopy.Attack.Name = "Ice Spike";
            mageCopy.Attack.Damage = 70;

            Knight knightCopy = new Knight();
            knightCopy.Health = knightOriginal.Health;
            knightCopy.Attack = knightOriginal.Attack;
            knightCopy.Armor = knightOriginal.Armor;
            knightCopy.Speed = 10;

            Console.WriteLine("--> Original Mage <--");
            mageOriginal.Details();

            Console.WriteLine();

            Console.WriteLine("--> Copy Mage <--");
            mageCopy.Details();

            Console.WriteLine();

            Console.WriteLine("--> Original Knight <--");
            knightOriginal.Details();

            Console.WriteLine();

            Console.WriteLine("--> Copy Knight <--");
            knightCopy.Details();
        }
    }
}
