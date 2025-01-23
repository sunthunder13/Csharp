
using Santander_csharp;
using System.Data.SqlClient;

namespace cmd
{
    internal class Data
    {
        static string connectionString
        = "Data Source =DESKTOP-IB8R0GG; Initial Catalog = car; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<car_specs> GetcarList()
        {
            var selectStatement = "SELECT * FROM carList";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var cars = new List<car_specs>();

            while (reader.Read())
            {
                cars.Add(new car_specs
                {
                    carBrand = reader["carBrand"].ToString(),
                    carYearModel = Convert.ToInt32(reader["carYearModel"].ToString())
                });
            }

            sqlConnection.Close();
            return cars;
        }
    }
}


