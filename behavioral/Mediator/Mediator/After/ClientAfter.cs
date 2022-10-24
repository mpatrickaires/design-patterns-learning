using Mediator.After.Components.Buttons;
using Mediator.After.Components.Checkboxes;
using Mediator.After.Components.Inputs;
using Mediator.After.Dialogs;
using Mediator.Common.Services;

/*
 * Let's understand what is happening.
 * 
 * Firstly, we created a new interface which represents the mediator. This interface simply exposes a method that takes as argument some
 * component; in our case, it will take the BaseComponent. The BaseComponent is an abstract class that defines the base for all components,
 * which is having a reference to a mediator and a method to set this said reference.
 * So, what happens is the following: we will have a concrete class to implement the mediator interface and thus be the mediator per se. The 
 * mediator will contain reference to all the concrete classes that take part of the logic and needs to be related; however, those concrete 
 * classes will not know or talk directly to each other, they will only know about the mediator interface (which allows to any class 
 * representing a mediator to beused) and will communicate anything directly to it. The mediator them will be notified about the event and thus
 * will take an action.
 * With that, our components can now be much more simple, giving us the advantage to reuse them anywhere and with whichever mediator. 
 * 
 * In conclusion, the mediator is basically that: the class which will encapsulate the reference to all the group of concrete classes which are
 * necessary, orchestrating the communication between them and doing the necessary business logic. All this coupling in only one place will 
 * allow those other classes to be easily reused.
 */

namespace Mediator.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("==========> After <==========");

            var emailInput = new Input();
            var passwordInput = new Input();
            var confirmPasswordInput = new Input();
            var button = new Button();
            var checkbox = new Checkbox();

            var dialog = new LoginOrRegisterDialog(emailInput, passwordInput, confirmPasswordInput, checkbox, button, new UserServices());

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
