namespace Mediator.Common.Services
{
    public class UserServices
    {
        private List<string> _users = new();

        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            if (email.Length < 3) return false;
            if (!email.EndsWith("@email.com")) return false;
            return true;
        }

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return false;
            if (password.Length < 5) return false;
            return true;
        }

        public void RegisterEmail(string email) => _users.Add(email);
        public bool EmailRegistered(string email) => _users.Any(u => u == email);
    }
}
