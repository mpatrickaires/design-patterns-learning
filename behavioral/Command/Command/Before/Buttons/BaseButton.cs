namespace Command.Before.Buttons
{
    public abstract class BaseButton
    {
        public string Caption { get; set; }

        public BaseButton(string caption)
        {
            Caption = caption;
        }

        public abstract void Click();
    }
}
