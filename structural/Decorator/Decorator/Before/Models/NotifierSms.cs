namespace Decorator.Before.Models
{
    public class NotifierSms : Notifier
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending SMS notification...");
        }
    }
}
