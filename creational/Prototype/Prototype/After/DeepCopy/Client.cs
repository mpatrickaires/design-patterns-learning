using Prototype.After.DeepCopy.Models.Attacks;
using Prototype.After.DeepCopy.Models.Characters;

/*
 * Now, with the Prototype implemented, we can get the copy of an object delegating the creation of that
 * copy to the class of the object itself. With that, we can have the advantage of the abstraction 
 * (as implemented in the CopyCharacters method) that we didn't have before using this pattern; also,
 * this allows to privates field (like the field Health in the class Character) to be copied, since 
 * they are being accessed by the own class.
 * This implementation is of the Deep Copy type, which means, as opposed to the Shallow Copy, that if
 * we copy an entity that has attributes that is an object, when we make changes at this object field
 * in the copied entity, the original entity will not suffer impacts at his object field. This happens
 * because in the Deep Copy we also create a new object for the attribute.
 */

namespace Prototype.After.DeepCopy
{
    public abstract class ClientDeepCopy
    {
        public static void Run()
        {
            Console.WriteLine("== After - DeepCopy ==");

            var mageOriginal = new Mage(80, 30, new Attack { Name = "Fireball", Damage = 100 }, 60);

            var knightOriginal = new Knight(160, 20, new Attack { Name = "Sword Attack", Damage = 80 }, 90);

            var characterList = CopyCharacters(mageOriginal, knightOriginal);

            var mageCopy = (Mage)characterList.FirstOrDefault(c => c is Mage);
            mageCopy.Mana = 80;
            // Here, the mageOriginal will NOT suffer the changes applied on the field Attack of the
            // mageCopy. This happens because the field Attack in the mageOriginal and the mageCopy
            // are pointing to different objects.
            mageCopy.Attack.Name = "Ice Spike";
            mageCopy.Attack.Damage = 70;

            var knightCopy = (Knight)characterList.FirstOrDefault(c => c is Knight);
            knightCopy.Speed = 10;

            Console.WriteLine("--> Mage Original <--");
            mageOriginal.Details();
            Console.WriteLine();

            Console.WriteLine("--> Mage Copy <--");
            mageCopy.Details();
            Console.WriteLine();

            Console.WriteLine("--> Knight Original <--");
            knightOriginal.Details();
            Console.WriteLine();

            Console.WriteLine("--> Knight Copy <--");
            knightCopy.Details();
        }

        public static List<Character> CopyCharacters(params Character[] characters)
        {
            var characterList = new List<Character>();
            foreach (var character in characters)
            {
                // Now we are cloning an object of the type Mage (mageOriginal) and another of the type
                // Knight (knightOriginal) as the abstraction of Character, which is a benefit of the
                // Prototype.
                Character characterCopy = character.Clone();
                characterList.Add(characterCopy);
            }

            return characterList;
        }
    }
}
