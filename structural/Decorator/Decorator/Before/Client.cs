using Decorator.Before.Models;

/*
 * Let's suppose we have an application that has a notifier system. The default behaviour of the 
 * notifier is to send it only at the application. But, let's say we wanted to expand this system by
 * adding the possibility of sending those notifications also by e-mail, SMS or both! Well, we gotta
 * a problem if we don't use Decorator...
 * To add those new implementations, what we could do is inherit from the default notifier class and
 * create new subclasses for e-mail, SMS and both. However, this is not a good practice because we
 * have to create those new subclasses for each new implementation we wanted to add and to each of those
 * combinations. If we wanted to notify also in Facebook, we would have to add many new subclasses; 
 * eventually, as new ideas of notification comes, we would have a class explosion due to the many combinations of functionalities we could have (also, the inheritance makes a kinda confusing code
 * and is not very good to be used by the client that way).
 */

namespace Decorator.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            NotifierEmail notifierEmail = new NotifierEmail();
            NotifierEmailSms notifierEmailSms = new NotifierEmailSms();

            Console.WriteLine("--> Default Notifier and E-mail");
            notifierEmail.Send("Message");
            Console.WriteLine();

            Console.WriteLine("--> Default Notifier, E-mail and SMS <--");
            notifierEmailSms.Send("Message");
        }
    }
}
