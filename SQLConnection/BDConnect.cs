using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace SQLConnection
{
    public class DBConnect
    {
        public SqlConnection connection { get; }
        public DBConnect()
        {
            var connectionString = new SqlConnectionStringBuilder
            {
                DataSource = "85.208.21.117,54321",
                InitialCatalog = "AlbaEmployees",
                UserID = "sa",
                Password = "Sql#123456789"
            };

            connection = new SqlConnection(connectionString.ToString());
        }

        public void Connect()
        {            
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    //MessageBox.Show("Connected to the database successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database:");
            }
        }
        public void Disconnect()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    //MessageBox.Show("Disconnected from the database.");                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disconnecting from the database:");
            }
        }
    }

}

