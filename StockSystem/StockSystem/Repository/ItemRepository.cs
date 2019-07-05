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
   public class ItemRepository
    {
        string connectionString = @"Server=IT\SQLEXPRESS; Database=StockSystem; Integrated Security=True";
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;
        //private DataSet dataSet;

        //public DataTable LoadItemCategory()
        //{


        //    sqlConnection = new SqlConnection(connectionString);

        //    commandString = @"SELECT CategoryName AS Category FROM Category";
        //    sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    sqlConnection.Open();

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);

        //    sqlConnection.Close();
        //    return dataTable;
        //}
        public DataTable LoadCategory()
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT * FROM Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
        public DataTable LoadCompany()
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT * FROM Company";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }





        public int InsertItem(Item item)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Item (ItemName,ItemReorder,CatID,ComID) VALUES ('" + item.ItemName+"',"+item.ItemReorder+","+item.CatID+","+item.ComID+")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

    }
}
