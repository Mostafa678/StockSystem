using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockSystem.Repository
{
    public class CategoryRepository
    {
        string connectionString = @"Server=GUB-D-01\SQLEXPRESS; Database=StockSystem; Integrated Security=True";
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;

        //public string ConnectionString { get => connectionString; set => connectionString = value; }

        public int InsertCategory(Category  category)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Category (CategoryName) VALUES ('" + category.CategoryName + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
        public DataTable ShowCategory()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"select * from Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;


        }
    }
}
