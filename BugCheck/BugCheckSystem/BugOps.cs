using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugCheckSystem
{
    public class BugOps
    {
        public static string connectionString = "Server=DESKTOP-6703GQI;Database=BugReportingDb;Trusted_Connection=True;";

        public static Bug Read(int id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM [dbo].[Bug] WHERE [id_Bug] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string title = (string)reader["Title"];
                        string desc = (string)reader["Description"];
                        string status = (string)reader["Status"];
                        int priority = (int)reader["Priority"];
                        return new Bug(id, title, desc, status, priority);
                    }
                }
            }
            return null;
        }

        public void Insert(Bug bug)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO [dbo].[Bug] ([Title], [Description], [id_AddedBy], [id_AssignedTo], [Status], [Priority], [id_Product_fk]) VALUES (@title, @desc, (SELECT id_Account FROM PersonalAccount, Bug WHERE id_Account = id_AddedBy), (SELECT id_Account FROM PersonalAccount, Bug WHERE id_Account = id_AssignedTo), @stat, @priority, (SELECT id_Product FROM Product, Bug WHERE id_Product = id_Product_fk))";
                    command.Parameters.AddWithValue("@title", bug.Title);
                    command.Parameters.AddWithValue("@desc", bug.Description);
                    command.Parameters.AddWithValue("@stat", bug.Status);
                    command.Parameters.AddWithValue("@priority", bug.Priority);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
