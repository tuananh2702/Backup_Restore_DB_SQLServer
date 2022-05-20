using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace đồ_án_chuyên_đề
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String ConnectionString;


        public static String ServerName = String.Empty;//D-N-A\MSSQLSERVER_TA
        public static String UserName = String.Empty;
        public static String Password = String.Empty;
        public static String TempDatabaseName = "tempdb";

        public static int namBatDau = 2016;
        public static int flagRestore = 0;
        public static string DefaultPath = @"C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER_TA\MSSQL\Backup";
        public static bool Connect()
        {
            try
            {
                ConnectionString = $"Data Source={ServerName};" +
                                          $"Initial Catalog={TempDatabaseName};" +
                                          $"User ID={UserName};" +
                                          $"password={Password}";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
                return true;
            }
            catch (Exception)
            {
                //ShowError(ex);
                return false;
            }
        }
        
        public static int ExecSqlNonQuery(string cmdText, string connectionString, string errstr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 600; //10p
                    try
                    {
                        command.ExecuteNonQuery();
                        return 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(errstr + "/n" + ex.Message);
                        conn.Close();
                        return ex.State;
                    }
                }
            }
        }
        public static string CreateDeviceName(string databaseName)
        {
            return string.Format("DEVICE_{0}", databaseName);
        }
     
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDangNhap());
        }
    }
}