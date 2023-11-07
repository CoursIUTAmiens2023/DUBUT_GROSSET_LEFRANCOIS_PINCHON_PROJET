using MySql.Data.MySqlClient;

namespace R5._08.Project.Database
{
    public class Database
    {
        public static MySqlConnection? m_DBConnection;

        public static bool OpenConnection()
        {
            string v_Server = "";
            string v_login = "";
            string v_Password = "";
            string v_Database = "";
            string v_ConnectionString = $"server={v_Server};uid={v_login};pwd={v_Password};database={v_Database}";

            m_DBConnection = new MySqlConnection(v_ConnectionString);

            try
            {
                m_DBConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool CloseConnection()
        {
            bool v_Result = false;
            if (m_DBConnection != null && m_DBConnection.State == System.Data.ConnectionState.Open)
            {
                m_DBConnection.Close();
                v_Result = true;
            }
            return v_Result;
        }
    }
}