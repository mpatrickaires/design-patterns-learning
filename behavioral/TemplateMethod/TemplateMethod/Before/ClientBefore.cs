using TemplateMethod.Before.Services;

/*
 * So, let's imagine the scenario where you have an application that is able to do data mining for some business to show relevant data (such as
 * the quantity of users per country and the quantity of premium users per country). Your application is now able to mine those data from CSV and
 * JSON files, having two separate classes those responsabilities; when the data is mined, a report is generated from it.
 * Everything looking good, however, if we look at the code from those classes (UsersCsvDataMiner and UsersJsonDataMiner), we'll see that most
 * of it is repeated code, that is because the routine of reading the bytes of a file, generating the report and those alike all have the same
 * behavior. So, basically, we have repeated code in different classes, and that would only get worse if we added the support to more file's type
 * (thus having to create a new class that will have more repeated code). 
 * 
 * Well, the Template Method design patterns brings to the table a way to solve this situation, so let's learn it.
 */

namespace TemplateMethod.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("===> Before <===");

            Console.WriteLine("(CSV)");
            var usersCsvDataMiner = new UsersCsvDataMiner("./Common/Data/users.csv");
            usersCsvDataMiner.GenerateReport();

            Console.WriteLine("\n===\n");

            Console.WriteLine("(JSON)");
            var usersJsonDataMiner = new UsersJsonDataMiner("./Common/Data/users.json");
            usersJsonDataMiner.GenerateReport();
        }
    }
}
