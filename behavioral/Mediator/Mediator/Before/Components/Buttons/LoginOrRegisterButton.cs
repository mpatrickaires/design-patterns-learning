using Mediator.Before.Components.Inputs;
using Mediator.Before.Dialogs;
using Mediator.Common.Services;

namespace Mediator.Before.Components.Buttons
{
    public class LoginOrRegisterButton
    {
        private LoginOrRegisterDialog _dialog;
        private Input _emailInput;
        private Input _passwordInput;
        private Input _confirmPasswordInput;
        private UserServices _userServices;
        public string Label { get; set; } = "Login";

        public LoginOrRegisterButton(LoginOrRegisterDialog dialog, Input emailInput, Input passwordInput, Input confirmPasswordInput,
            UserServices userServices)
        {
            _dialog = dialog;
            _emailInput = emailInput;
            _passwordInput = passwordInput;
            _userServices = userServices;
            _confirmPasswordInput = confirmPasswordInput;
        }

        public void Click()
        {
            var email = _emailInput.Value;
            var password = _passwordInput.Value;

            if (_dialog.IsLogin)
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
}
