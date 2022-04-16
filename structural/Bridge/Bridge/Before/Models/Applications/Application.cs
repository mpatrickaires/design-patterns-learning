namespace Bridge.Before.Models.Applications
{
    public abstract class Application
    {
        public void Initialize()
        {
            Render();
            Notify("Application successfully initialized!");
        }
        protected abstract void Render();
        protected abstract void Notify(string message);
    }
}
