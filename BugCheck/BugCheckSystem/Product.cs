using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BugCheckSystem
{
    public class Product
    {
        public static string connectionString = "Server=DESKTOP-6703GQI;Database=BugReportingDb;Trusted_Connection=True;";

        private int Id { get; set; }

        private string Name { get; set; }

        private string Type { get; set; }

        private string Description { get; set; }

        public Product() { }

        public Product(string name, string type, string desc)
        {
            Name = name;
            Type = type;
            Description = desc;
        }

        public Product(int id, string name, string type, string desc)
        {
            Id = id;
            Name = name;
            Type = type;
            Description = desc;
        }

        #region CRUD ops
        public void Create(Product product)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO [dbo].[Product] ([Name], [Type], [Description]) VALUES (@name, @type, @desc)";
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@type", product.Type);
                    command.Parameters.AddWithValue("@desc", product.Description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static Product Read(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM [dbo].[Product] WHERE [id_Product] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string name = (string)reader["Name"];
                        string type = (string)reader["Type"];
                        string desc = (string)reader["Description"];
                        return new Product(id, name, type, desc);
                    }
                }
            }
            return null; 
        }
        
        public void Update(string type, string desc)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE [dbo].[Product] SET [Type] = @type, [Description] = @desc WHERE [id_Product] = @id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@desc", desc);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM [dbo].[Product] WHERE [id_Product] = @id";
                    command.Parameters.AddWithValue("@id", Id);

                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion CRUD
    }
}
