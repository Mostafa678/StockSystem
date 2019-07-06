using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.Models;

namespace StockSystem.Repository
{
    public class StockInRepository
    {
        string connectionString = @"Server=IT\SQLEXPRESS; Database=StockSystem; Integrated Security=True";
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;
        
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
        //public string category()
        //{
        //    sqlConnection = new SqlConnection(connectionString);

        //    commandString = @"select * from Category,Company where CompanyID= "+stockIn.ComID+"";
        //    return commandString;
        //}
        //public DataTable LoadCategory()
        //{
        //    sqlConnection = new SqlConnection(connectionString);

        //    commandString = category();
        //    sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    sqlConnection.Open();

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);

        //    sqlConnection.Close();
        //    return dataTable;
        //}


        public DataTable LoadCategory(StockIn stockIn)
        {

            commandString = @"select CategoryName from Item as i,Category  where  CategoryID=i.CatID and i.ComID = "+stockIn.ComID+"";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;

            sqlConnection.Close();

            return dataTable;

        }


    }
}
