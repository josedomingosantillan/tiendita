using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tiendita
{
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConectDB conect = new ConectDB();
            conect.Menu();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _nombre_producto = nombre_producto.Text, _descripcion_producto = descripcion_producto.Text, _categoria_producto = categoria_producto.Text;


                if (precio_producto.Text == "" && stock_producto.Text == "" && _nombre_producto == "" && _descripcion_producto == "" && _categoria_producto == "")
                {
                    MessageBox.Show("Todos los campos deben de estar llenos.");
                    return;
                }
                int _stock_producto = Convert.ToInt32(stock_producto.Text);

                double _precio_producto = Convert.ToDouble(precio_producto.Text);



                ConectDB oracleDBManager = new ConectDB();

                string sqlInsert = $"INSERT INTO tiendita_productos (nombre,descripcion,precio,stock,categoria) VALUES ('{_nombre_producto}', '{_descripcion_producto}', '{_precio_producto}','{_stock_producto}','{_categoria_producto}')";

                oracleDBManager.ExecuteNonQuery(sqlInsert);

                MessageBox.Show("Registro Agregado Exitosamente.");

                oracleDBManager.Menu();
                this.Hide();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}
