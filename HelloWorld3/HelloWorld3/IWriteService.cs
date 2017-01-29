using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HelloWorld3
{
    public interface IWriteService
    {
        string Write(string text);
    }

    public class ConsoleWriteService : IWriteService
    {
        public string Write(string text)
        {
            Console.WriteLine(text);
            return text;
        }
    }

    public class DatabaseWriteService : IWriteService
    {
        public string Write(string text)
        {
            string result = "";

            // write to db
            SqlConnection connection;

            // opens database and writes to a table called "Messages"
            using (connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HellWorldConnection"].ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Messages (Message) Values (@0)", connection);
                command.Parameters.AddWithValue("0", text);
                var success = command.ExecuteNonQuery();

                if(success == 1)
                {
                    result = text;
                }
            }

            return result;
        }
    }

    public class MessageBoxWriteService : IWriteService
    {
        public string Write(string text)
        {
            MessageBox.Show(text);

            return text;
        }
    }
}
