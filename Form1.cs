namespace tiendita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultar consulta = new consultar();
            consulta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregar agrega = new agregar();
            agrega.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            store_procedure stp = new store_procedure();
            stp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            trigger stp = new trigger();
            stp.Show();
        }
    }
}
