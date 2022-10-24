using Mediator.After.Components;
using Mediator.After.Components.Buttons;
using Mediator.After.Components.Checkboxes;
using Mediator.After.Components.Inputs;
using Mediator.Common.Services;

namespace Mediator.After.Dialogs
{
    public class LoginOrRegisterDialog : IMediator
    {
        private Input _emailInput;
        private Input _passwordInput;
        private Input _confirmPasswordInput;
        private Checkbox _checkbox;
        private Button _button;
        private UserServices _userServices;
        public string Title { get; set; } = "Login";

        public LoginOrRegisterDialog(Input emailInput, Input passwordInput, Input confirmPasswordInput, Checkbox checkbox, Button button, UserServices userServices)
        {
            _emailInput = emailInput;
            _emailInput.Label = "Email";
            _emailInput.SetMediator(this);

            _passwordInput = passwordInput;
            _passwordInput.Label = "Password";
            _passwordInput.SetMediator(this);

            _confirmPasswordInput = confirmPasswordInput;
            _confirmPasswordInput.Label = "Confirm Password";
            _confirmPasswordInput.SetMediator(this);

            _checkbox = checkbox;
            _checkbox.Label = "New Account?";
            _checkbox.SetMediator(this);

            _button = button;
            _button.Label = "Login";
            _button.SetMediator(this);

            _userServices = userServices;
        }

        public void Update(BaseComponent component)
        {
            if (component == _checkbox)
            {
                if (IsLogin)
                {
                    Title = "Login";
                    _button.Label = "Login";
                    _confirmPasswordInput.Visible = false;
                }
                else
                {
                    Title = "Register";
                    _button.Label = "Create Account";
                    _confirmPasswordInput.Visible = true;
                }
            }
            else if (component == _button)
            {
                var email = _emailInput.Value;
                var password = _passwordInput.Value;

                if (IsLogin)
                {
                    if (_userServices.EmailRegistered(email))
                    {
                        Console.WriteLine($"Successful login! Welcome back, {email}");
                    }
                    else
                    {
                        Console.WriteLine($"Error in login! No user found for the email {email}");
                    }
                }
                else
                {
                    if (!_userServices.ValidateEmail(email))
                    {
                        Console.WriteLine($"Error in the registration! The email {email} is not valid!");
                        return;
                    }
                    if (!_userServices.ValidatePassword(password))
                    {
                        Console.WriteLine($"Error in the registration! The password is not valid!");
                        return;
                    }
                    if (password != _confirmPasswordInput.Value)
                    {
                        Console.WriteLine($"Error in the registration! The passwords doesn't match!");
                        return;
                    }
                    if (_userServices.EmailRegistered(email))
                    {
                        Console.WriteLine($"Error in the registration! The email {email} is already registered!");
                        return;
                    }

                    _userServices.RegisterEmail(email);
                    Console.WriteLine($"Successful registration! Enjoy your new account, {email}");
                }
            }
        }

        private bool IsLogin => !_checkbox.Checked();
    }
}
