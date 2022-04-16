using Bridge.Before.Models.Platforms;

namespace Bridge.Before.Models.Applications
{
    public class PrimaryApplicationWindows : Application
    {
        private readonly Windows _windows = new Windows();

        protected override void Render()
        {
            Console.WriteLine("Rendering Primary Application");
            _windows.Button();
            _windows.Input();
        }

        protected override void Notify(string message)
        {
            _windows.Notification($"[Primary Application] {message}");
        }
    }
}
