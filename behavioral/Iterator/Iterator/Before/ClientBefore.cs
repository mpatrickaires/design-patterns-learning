using ExcelDataReader;
using Iterator.Model;

namespace Iterator.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            foreach (string line in File.ReadLines("./Data/users.csv"))
            {
                string[] fields = line.Split(';');

                var user = new User
                {
                    Name = fields[0],
                    Age = int.Parse(fields[1]),
                    Country = fields[2],
                };

                Console.WriteLine(user);
            }

            using FileStream stream = File.Open("./Data/users.xlsx", FileMode.Open, FileAccess.Read);
            using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
            while (reader.Read())
            {
                if (reader.IsDBNull(0)) break;

                var user = new User
                {
                    Name = reader.GetString(0),
                    Age = Convert.ToInt32(reader.GetDouble(1)),
                    Country = reader.GetString(2),
                };

                Console.WriteLine(user);
            }
        }
    }
}
