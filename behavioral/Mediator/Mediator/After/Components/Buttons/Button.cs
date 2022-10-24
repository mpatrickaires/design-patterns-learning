namespace Mediator.After.Components.Buttons
{
    public class Button : BaseComponent
    {
        public string Label { get; set; }
        public void Click() => Notify();
    }
}
