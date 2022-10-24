using Mediator.Before.Components.Buttons;
using Mediator.Before.Components.Inputs;
using Mediator.Before.Dialogs;

namespace Mediator.Before.Components.Checkboxes
{
    public class LoginOrRegisterCheckbox
    {
        private LoginOrRegisterDialog _dialog;
        private LoginOrRegisterButton _button;
        private Input _confirmPasswordInput;
        private bool _value = false;
        public bool Checked => _value;
        public string Label => "New Account?";

        public LoginOrRegisterCheckbox(LoginOrRegisterDialog dialog, LoginOrRegisterButton button, Input confirmPasswordInput)
        {
            _dialog = dialog;
            _button = button;
            _confirmPasswordInput = confirmPasswordInput;
        }

        public void Check()
        {
            _value = !_value;

            if (!_value)
            {
                _dialog.Title = "Login";
                _button.Label = "Login";
                _confirmPasswordInput.Visible = false;
            }
            else
            {
                _dialog.Title = "Register";
                _button.Label = "Create Account";
                _confirmPasswordInput.Visible = true;
            }
        }
    }
}
