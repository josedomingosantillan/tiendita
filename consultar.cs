using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tiendita
{
    public partial class consultar : Form
    {
        private DataTable data;
        public consultar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConectDB cone = new ConectDB();
            cone.Menu();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT * from tiendita_productos";

                data = oracleDBManager.ExecuteQueryUsers(query);

                tableproductos.DataSource = data;
                id_producto.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id_product = Convert.ToInt32(id_producto.Text);
                if (id_product <= 0)
                {
                    MessageBox.Show("No puede estar vacio el campo de id");
                }
                else
                {
                    ConectDB oracleDBManager = new ConectDB();

                    string query = $"SELECT * from tiendita_productos where id_producto = {id_producto.Text}";

                    data = oracleDBManager.ExecuteQueryUsers(query);

                    tableproductos.DataSource = data;
                    id_producto.Text = "";
                }


            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT sum(tp.precio) from tiendita_productos tp";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    suma_precios.Text += " " + suma.ToString();
                }
                else
                {

                    suma_precios.Text += " No se encontraron datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT avg(tp.precio) from tiendita_productos tp";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    suma_precios.Text += " " + suma.ToString();
                }
                else
                {

                    suma_precios.Text += " No se encontraron datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT avg(tp.precio) from tiendita_productos tp";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    promedio_precios.Text += " " + suma.ToString();
                }
                else
                {

                    promedio_precios.Text += " No se encontraron datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT avg(tp.precio) from tiendita_productos tp";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    promedio_precios.Text += " " + suma.ToString();
                }
                else
                {

                    promedio_precios.Text += " No se encontraron datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT max(tp.precio) from tiendita_productos tp";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    precio_m.Text = "Precio Máximo: " + suma.ToString();
                }
                else
                {

                    precio_m.Text += " No se encontraron datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT min(tp.precio) from tiendita_productos tp";

                object result = oracleDBManager.ExecuteScalar(query);

                if (result != null && result != DBNull.Value)
                {
                    decimal suma = Convert.ToDecimal(result);
                    precio_m.Text = "Precio Mínimo: " + suma.ToString();
                }
                else
                {

                    precio_m.Text += " No se encontraron datos";
                }

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ConectDB oracleDBManager = new ConectDB();

                string query = $"SELECT nombre,precio,stock from tiendita_productos";

                data = oracleDBManager.ExecuteQueryUsers(query);

                tableproductos.DataSource = data;
                id_producto.Text = "";

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine($"Error de Oracle: {ex.Message}");
            }
        }
    }
}
