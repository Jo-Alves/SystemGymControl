namespace Bussiness
{
    public class database
    {
        public static bool ExistsDatabase()
        {
            return Database.database.ExistsDatabase();
        }

        public static void CreateDatabase()
        {
            Database.database.CreateDatabase();
        }

        public static void CreateTables()
        {
            Database.database.CreateTables();
        }

    }
}
