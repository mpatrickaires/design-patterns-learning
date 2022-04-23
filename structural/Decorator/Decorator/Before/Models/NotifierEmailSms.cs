namespace Decorator.Before.Models
{
    public class NotifierEmailSms : NotifierEmail
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending SMS notification...");
        }
    }
}
