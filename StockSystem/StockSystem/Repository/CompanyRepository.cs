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
    class CompanyRepository
    {
        string connectionString = @"Server=IT\SQLEXPRESS; Database=StockSystem; Integrated Security=True";
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;
        private DataSet dataSet;



        public int InsertCompany(Company company)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Company (CompanyName) VALUES ('" + company.CompanyName + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
        public int IsExisted(Company company)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"select * from Company  where CompanyName='" + company.CompanyName + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);
            int isExisted = dataSet.Tables[0].Rows.Count;
            sqlConnection.Close();
            return isExisted;
        }
        public DataTable ShowCompany()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"select * from Company ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public int UpdateCompany(Company company)
        {
            commandString = @"UPDATE Company  SET CompanyName= '" + company.CompanyName + "' WHERE CompanyID='" + company.CompanyID + "'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();



            sqlConnection.Close();

            return isExecuted;
        }


    }
}
