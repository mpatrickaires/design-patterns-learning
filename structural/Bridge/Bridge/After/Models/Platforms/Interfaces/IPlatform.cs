namespace Bridge.After.Models.Platforms.Interfaces
{
    public interface IPlatform
    {
        public void DisplayButton();
        public void DisplayInput();
        public void DisplayNotification(string message);
    }
}
