using Bridge.After.Models.Platforms.Interfaces;

namespace Bridge.After.Models.Applications
{
    public abstract class Application
    {
        protected IPlatform Platform;

        public Application(IPlatform platform)
        {
            Platform = platform;
        }

        public void Initialize()
        {
            Render();
            Notify("Application successfully initialized!");
        }
        protected abstract void Render();
        protected abstract void Notify(string message);
    }
}
