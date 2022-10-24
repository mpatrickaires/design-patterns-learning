using Mediator.Before.Components.Buttons;
using Mediator.Before.Components.Checkboxes;
using Mediator.Before.Components.Inputs;
using Mediator.Before.Dialogs;
using Mediator.Common.Services;

/*
 * So, let's say we have an application containing a dialog for the user perform login or registration actions.
 * This dialog contains some components and some logic happens when the user interact with some of those components. However, in the actual
 * state of the application, those components are tightly coupled between themselves and contains too much business logic behind their events. 
 * This is something bad, because if we wanted to reuse those components somewhere else (another dialog or even another application), we would 
 * need to also transport all it dependencies or it would not be possible to reuse; we would also need to set many 'ifs' in the code to change 
 * the logic based in where the component is being used. Pretty ugly, uh?
 * 
 * Well, it seems we need to have a better approach for that, and this is where the Mediator pattern comes in scene!
 */

namespace Mediator.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("==========> Before <==========");
            var dialog = new LoginOrRegisterDialog();

            var emailInput = new Input("Email", true);
            var passwordInput = new Input("Password", true);
            var confirmPasswordInput = new Input("Confirm Password", false);
            var button = new LoginOrRegisterButton(dialog, emailInput, passwordInput, confirmPasswordInput, new UserServices());
            var checkbox = new LoginOrRegisterCheckbox(dialog, button, confirmPasswordInput);

            dialog.SetEmailInput(emailInput);
            dialog.SetPasswordInput(passwordInput);
            dialog.SetConfirmPasswordInput(confirmPasswordInput);
            dialog.SetButton(button);
            dialog.SetCheckbox(checkbox);

            emailInput.Value = "darth-vader@.com";
            passwordInput.Value = "abc";
            button.Click();

            checkbox.Check();
            button.Click();

            emailInput.Value = "darth-vader@email.com";
            passwordInput.Value = "iamyourfather";
            button.Click();

            confirmPasswordInput.Value = "iamyourfather";
            button.Click();

            button.Click();
        }
    }
}
