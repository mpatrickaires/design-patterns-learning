namespace Iterator.Model
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} - Age: {Age} - Country: {Country}";
        }
    }
}
