using Flyweight.Before.Models;

/*
 * Let's suppose we have a game that contains particles of bullets and rockets. Every time a player
 * shoots, a new particle object is created containing the name, sprite, color, coordinates and speed
 * of this particle.
 * However, let's take a better look at those objects: the name, sprite and color states repeats 
 * themselves across many objects and are immutable, and those are states that, in a real software, could consume a great chunk of memory. 
 * So, repeating those states across those objects may not be the best way to handle this scenario, 
 * because we would have an unecessary usage of memory that could even crash the application in
 * weaker hardware.
 * We should reuse them and thus save in memory, and it is exactly this that the Flyweight looks to 
 * solve.
 * 
 * Talking more about the example, those states that are common and immutable are called intrinsic 
 * state, and the ones that are unique for each object and can be mutable are called extrinsic state. 
 * To better illustrate how each of those intrinsic states are always being created for each new object,
 * an Id field was created and before the implementation of the Flyweight, it is differente for each
 * object, but after the implementation it is the same for each repetition of those states, showing
 * better that we are using the same instance of object for those states (since the Id are the same
 * between them).
 */

namespace Flyweight.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            Particle bulletParticle = new Particle("Bullet", "bullet.png", "Red", 80, 20, 30);
            Particle bulletParticle2 = new Particle("Bullet", "bullet.png", "Red", 50, 10, 90);

            Particle missileParticle = new Particle("Missile", "missile.png", "Black", 20, 50, 50);
            Particle missileParticle2 = new Particle("Missile", "missile.png", "Black", 25, 80, 10);

            Console.WriteLine("--> Bullet Particle 1 <--");
            bulletParticle.Draw();
            bulletParticle.Move();

            Console.WriteLine("--> Bullet Particle 2 <--");
            bulletParticle2.Draw();
            bulletParticle2.Move();

            Console.WriteLine("--> Missile Particle 1 <--");
            missileParticle.Draw();
            missileParticle.Move();

            Console.WriteLine("--> Missile Particle 2 <--");
            missileParticle2.Draw();
            missileParticle2.Move();
        }
    }
}
