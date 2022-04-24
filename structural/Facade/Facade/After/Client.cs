using Facade.After.Facades;
using Facade.Models;

/*
 * Now, using the Facade, we are able to use the client withou exposing to it the external services we 
 * are actually using. The way to do that is to create a class (that represents the facade) and make 
 * that class do the communication to this external code we need, applying all the necessary logic
 * at this facade.
 * With that, the client now only needs to know about the facade and is coupled only to that (and also
 * at the User model, but that is more forgiving), so if we wanted to change the library we use 
 * now, it would be a matter of only doing changes at the facade, without needing to impact the 
 * client or any other piece of code that may use it.
 * It's important to note that the facade can also be simplist. That is, we don't have to implement 
 * everything that is available by the library for it to work: we can use just what we need. Analysing 
 * our example, the class Security has a method for two factor authentication, but we don't 
 * need that right now at our application, with that we don't have to use it at the facade (just like 
 * we didn't used at the Before example), but, if in the future we decide to use it, that could be as 
 * easy as adding it at the login routine of the facade (but obviously everything depends of the 
 * business logic and how a code in a real enviroment would be, this is just a perfect world for the 
 * sake of the example).
 */

namespace Facade.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");
            UserFacade userFacade = new UserFacade();

            User user = new User();
            user.Email = "johndoe@test.com";
            user.Name = "John Doe";

            userFacade.RegisterUser(user, "abc123");
            userFacade.Login(user, "abc123");
        }
    }
}
