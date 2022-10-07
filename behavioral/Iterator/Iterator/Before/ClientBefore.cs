using ExcelDataReader;
using Iterator.Model;

/*
 * So, let's imagine the following: you have two datasets containing users, and those two dataset 
 * are in different formats (in our example, one is a CSV and the other an Excel File).
 * Your job is to go through those datasets, retrieve the data of each position of it containing a 
 * record, convert it to your user object, and then display the retrieved data.
 * Well, is this didn't looked like a great overhead already, considering that your datasets are in 
 * different formats, the logic of going through then is different, so your code will need to have 
 * different paths for each format. The client shouldn't need to know the rules and how to iterate
 * different kinds of datasets, it just needs a collection of users to go through.
 * To solve this situation (which is represented in the following code), we can use the pattern 
 * Iterator.
 */

namespace Iterator.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");
            Console.WriteLine("--> Reading from CSV:");
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

            Console.WriteLine("\n--> Reading from Excel:");
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
