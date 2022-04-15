using Prototype.After.ShallowCopy.Models.Attacks;
using Prototype.After.ShallowCopy.Models.Characters;

/*
 * Now, with the Prototype implemented, we can get the copy of an object delegating the creation of that
 * copy to the class of the object itself. With that, we can have the advantage of the abstraction 
 * (as implemented in the CopyCharacters method) that we didn't have before using this pattern; also,
 * this allows to privates field (like the field Health in the class Character) to be copied, since 
 * they are being accessed by the own class.
 * However, this implementation is of the Shallow Copy type, which means if the object being copied
 * has an attribute that also is an object (in this case, the class Character has an attribute that 
 * is an object of the class Attack), this attribute will be copied as an reference to the same object,
 * what that means is that if we change the attribute object in the copied entity, the original entity
 * will see this change. 
 * To contour this, we have the Deep Copy implementation.
 */

namespace Prototype.After.ShallowCopy
{
    public abstract class ClientShallowCopy
    {
        public static void Run()
        {
            Console.WriteLine("== After - ShallowCopy ==");

            var mageOriginal = new Mage(80, 30, new Attack { Name = "Fireball", Damage = 100 }, 60);

            var knightOriginal = new Knight(160, 20, new Attack { Name = "Sword Attack", Damage = 80 }, 90);

            var characterList = CopyCharacters(mageOriginal, knightOriginal);

            var mageCopy = (Mage)characterList.FirstOrDefault(c => c is Mage);
            mageCopy.Mana = 80;
            // Here, the mageOriginal will suffer the changes applied on the field Attack of the
            // mageCopy. This happens because the field Attack is pointing to the same object in both
            // mageOriginal and mageCopy.
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
