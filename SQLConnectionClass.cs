using System.Configuration;

namespace Capstone
{
    public class SQLConnectionClass
    {

        public static string ConnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
