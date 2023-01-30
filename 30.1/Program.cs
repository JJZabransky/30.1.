using System.Data.SqlClient;

namespace _30._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
            consStringBuilder.UserID = "sa";
            consStringBuilder.Password = "student";
            consStringBuilder.InitialCatalog = "test";
            consStringBuilder.DataSource = "PC979";
            consStringBuilder.ConnectTimeout = 30;

            lmao l = new lmao(1,"Dan","Dzus");
            try
            {
                using (SqlConnection connection = new SqlConnection(consStringBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Pripojeno");

                    string query = "use xd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    
                    l.Vklad(connection, l.Jmeno, l.Prijmeni);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}