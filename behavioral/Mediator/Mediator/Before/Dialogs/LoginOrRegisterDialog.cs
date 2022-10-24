using Mediator.Before.Components.Buttons;
using Mediator.Before.Components.Checkboxes;
using Mediator.Before.Components.Inputs;

namespace Mediator.Before.Dialogs
{
    public class LoginOrRegisterDialog
    {
        private Input _emailInput;
        private Input _passwordInput;
        private Input _confirmPasswordInput;
        private LoginOrRegisterCheckbox _checkbox;
        private LoginOrRegisterButton _button;
        public string Title { get; set; } = "Login";
        public bool IsLogin => !_checkbox.Checked;

        public void SetEmailInput(Input input) => _emailInput = input;
        public void SetPasswordInput(Input input) => _passwordInput = input;
        public void SetConfirmPasswordInput(Input input) => _confirmPasswordInput = input;
        public void SetCheckbox(LoginOrRegisterCheckbox checkbox) => _checkbox = checkbox;
        public void SetButton(LoginOrRegisterButton button) => _button = button;
    }
}
