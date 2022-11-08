using TemplateMethod.Common.Enums;

namespace TemplateMethod.Common.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Country Country { get; set; }
        public bool Premium { get; set; }
    }
}
