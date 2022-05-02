using Flyweight.After.Models;

/*
 * Now, applying the Flyweight pattern, we have a separate class to store all the intrinsic states 
 * (those that are repeated between many objects and are immutable) called FlyweightParticle, which is
 * then wrapped inside the Particle class. The idea is that those Particle objects that shares the same
 * intrinsic state will also share the same instance of FlyweightParticle to represent those states.
 * Since in our example those states could demand some high memory usage, keeping them in only one
 * instance will greatly reduce this usage.
 * To achieve that reusage of instances, we have a factory that contains the pool of FlyweightParticle
 * that were already created. When creating a new Particle object, its constructor will receive the 
 * intrinsic state and will pass it to the factory to look up for an already existing instance of the 
 * FlyweightParticle that has this state; if this instance doesn't exists yet, it will be created and 
 * then reused always that an object containing this same state is required.
 */

namespace Flyweight.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

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
