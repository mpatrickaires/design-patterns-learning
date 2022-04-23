using Decorator.After.Models;
using Decorator.After.Models.Decorators;
using Decorator.After.Models.Interfaces;

/*
 * Now, using the Decorator, we created an interface of the notifier and we use composition 
 * instead of inheritance.
 * About the decorator, its objective is to expand the behaviour of a certain class without having to 
 * deal with the inheritance, which is a good practice.
 * Basically, we now have our notifier implementing the interface and also a new class that represents 
 * the base decorator of the notifier; the base decorator is an abstract class that has a field of the
 * type of the interface and also implements the interface (the importance of that is explained later) 
 * simply by calling the wrapped object.
 * After that, we also have the concrete decorators, which inherits from the base decorator. The 
 * decorators will also need to have the wrapped object (because the inherited base decorator expects 
 * this) and their main purpose is to override the base decorator method(s) and then do the
 * implementation of a new behaviour that will be executed before or after the one of the wrapped object
 * (the calling of this method of the wrapped object will be made by calling the parent decorator
 * method, which will then call the one of the wrapped object since it just delegates to it).
 * The reason why we made the base decorator implement the same interface as the one of the wrapped 
 * object is because this allows us to pass a decorator to another decorator, which will make possible
 * to create a stack of decorators that will be called one after another (in our example, we wrapped
 * the EmailDecorator inside the SmsDecorator, allowing to send notifications through both: first
 * by the EmailDecorator and then by the SmsDecorator, because the order in which the decorators are
 * wrapped actually matters).
 * That's it, with the decorator we will not have problems if we new wanted to add new channels of 
 * notification: we would just need to create the concrete decorator and use it whenever we want. 
 * It's also important to mention that this way is much easier to change the concrete implementation of 
 * the notifier, as the decorators will not suffer from this change since they only care about the 
 * interface.
 */

namespace Decorator.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

            INotifier notifierEmail = new Notifier();
            notifierEmail = new EmailDecorator(notifierEmail);

            INotifier notifierEmailSms = new Notifier();
            notifierEmailSms = new EmailDecorator(notifierEmailSms);
            notifierEmailSms = new SmsDecorator(notifierEmailSms);

            Console.WriteLine("--> Default Notifier and E-mail");
            notifierEmail.Send("Message");
            Console.WriteLine();

            Console.WriteLine("--> Default Notifier, E-mail and SMS <--");
            notifierEmailSms.Send("Message");
        }
    }
}
