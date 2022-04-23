namespace Decorator.Before.Models
{
    public class NotifierEmail : Notifier
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending e-mail notification...");
        }
    }
}
