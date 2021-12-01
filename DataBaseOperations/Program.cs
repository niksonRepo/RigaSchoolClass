using System.Data.SqlClient;

namespace DataBaseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=(local);Initial Catalog=UniversityDB;Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString = "select * from Students " +
                                 "where Name = @name";

            // Specify the parameter value.
            var paramValue = "John";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    //SqlDataReader reader = command.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    //please full field your object properties here
                    //    Console.WriteLine("\t{0}\t{1}\t{2}",
                    //        reader[0], reader[1], reader[2]);
                    //}
                    //reader.Close();
                    Console.WriteLine("Successfully execute script");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}