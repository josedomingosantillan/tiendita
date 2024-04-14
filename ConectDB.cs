using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tiendita
{
    internal class ConectDB
    {
        private readonly string _connectionString;
        private OracleConnection _connection;

        public ConectDB()
        {

            _connectionString = "User Id=SYSTEM;Password=chivasDE1;Data Source=localhost:1521/FREE;";
        }

        public void OpenConnection()
        {
            if (_connection == null)
            {
                _connection = new OracleConnection(_connectionString);
            }

            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
                Console.WriteLine("Conexión abierta");
            }
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }

        public void Menu()
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        public DataTable ExecuteQueryUsers(string sql)
        {
            OpenConnection();

            using (OracleCommand cmd = new OracleCommand(sql, _connection))
            {
                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public object ExecuteScalar(string sql)
        {
            OpenConnection();

            using (OracleCommand cmd = new OracleCommand(sql, _connection))
            {
                try
                {
                    object result = cmd.ExecuteScalar();
                    return result;
                }
                catch (OracleException ex)
                {
                    throw ex;
                }
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            try
            {
                OpenConnection();

                using (OracleCommand command = new OracleCommand(sql, _connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Se insertaron {rowsAffected} registros correctamente.");

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
