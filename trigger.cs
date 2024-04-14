using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiendita
{
    public partial class trigger : Form
    {
        public trigger()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_producto.Text == "")
                {
                    MessageBox.Show("Todos los campos deben estar llenos.");
                    return;
                }

                ConectDB oracleDBManager = new ConectDB();

                // Preparar la consulta SQL para llamar al procedimiento almacenado
                string sqlInsert = $"BEGIN incrementar_stock({id_producto.Text}); END;";

                // Ejecutar la consulta SQL
                oracleDBManager.ExecuteNonQuery(sqlInsert);

                MessageBox.Show("Stock actualizado correctamente.");
                oracleDBManager.Menu();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
