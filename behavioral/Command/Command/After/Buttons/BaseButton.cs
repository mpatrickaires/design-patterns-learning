using Command.After.Commands.Interfaces;

namespace Command.After.Buttons
{
    public class BaseButton
    {
        private readonly ICommand _command;
        public string Caption { get; set; }

        public BaseButton(string caption, ICommand command)
        {
            Caption = caption;
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}
