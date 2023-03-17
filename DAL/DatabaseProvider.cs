using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseProvider
    {
        private static DatabaseProvider instance;

        public static DatabaseProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseProvider();
                return instance;
            }
        }
        private DatabaseProvider() { }
        private string sql = "initial catalog = SEProject; data source = LAPTOP-V7FVFKTA\\SQLEXPRESS; integrated security = true";
        public DataTable ExecuteQueryCmd(string cmd) {
            SqlConnection connection = new SqlConnection(sql);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = cmd;
            adapter.SelectCommand= command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public void ExecuteNonQueryCmd(string cmd)
        {
            SqlConnection connection = new SqlConnection(sql);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = cmd;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
