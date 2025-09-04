using MySql.Data.MySqlClient;
namespace test
{
    internal class DataBase
    {
        public static MySqlConnection Connection()
        {
          string conn ="server=localhost;user=root;password=admin;database=Digital_Diary";
            return new MySqlConnection(conn);
        }
    }
}
