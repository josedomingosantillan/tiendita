namespace tiendita
{
    partial class consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            id_producto = new TextBox();
            tableproductos = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            suma_precios = new Label();
            button5 = new Button();
            promedio_precios = new Label();
            button6 = new Button();
            precio_m = new Label();
            button7 = new Button();
            button8 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableproductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(421, 46);
            label1.TabIndex = 1;
            label1.Text = "Consultar productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(35, 80);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 23);
            label3.TabIndex = 3;
            label3.Text = "Consulta General:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(528, 89);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 4;
            label2.Text = "Consulta específica:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.Location = new Point(35, 123);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(259, 42);
            button1.TabIndex = 6;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F);
            button2.Location = new Point(823, 123);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(176, 42);
            button2.TabIndex = 7;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // id_producto
            // 
            id_producto.Location = new Point(528, 133);
            id_producto.Name = "id_producto";
            id_producto.Size = new Size(286, 27);
            id_producto.TabIndex = 8;
            // 
            // tableproductos
            // 
            tableproductos.AllowUserToAddRows = false;
            tableproductos.AllowUserToDeleteRows = false;
            tableproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableproductos.Location = new Point(40, 356);
            tableproductos.Name = "tableproductos";
            tableproductos.ReadOnly = true;
            tableproductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            tableproductos.Size = new Size(959, 222);
            tableproductos.TabIndex = 9;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.Location = new Point(367, 601);
            button3.Margin = new Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new Size(259, 42);
            button3.TabIndex = 10;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 12F);
            button4.Location = new Point(40, 260);
            button4.Margin = new Padding(6, 5, 6, 5);
            button4.Name = "button4";
            button4.Size = new Size(259, 42);
            button4.TabIndex = 12;
            button4.Text = "Suma";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // suma_precios
            // 
            suma_precios.AutoSize = true;
            suma_precios.Font = new Font("Arial Rounded MT Bold", 12F);
            suma_precios.Location = new Point(40, 217);
            suma_precios.Margin = new Padding(6, 0, 6, 0);
            suma_precios.Name = "suma_precios";
            suma_precios.Size = new Size(180, 23);
            suma_precios.TabIndex = 11;
            suma_precios.Text = "Suma de Precios:";
            // 
            // button5
            // 
            button5.Font = new Font("Arial Rounded MT Bold", 12F);
            button5.Location = new Point(337, 260);
            button5.Margin = new Padding(6, 5, 6, 5);
            button5.Name = "button5";
            button5.Size = new Size(259, 42);
            button5.TabIndex = 14;
            button5.Text = "Obtener";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // promedio_precios
            // 
            promedio_precios.AutoSize = true;
            promedio_precios.Font = new Font("Arial Rounded MT Bold", 12F);
            promedio_precios.Location = new Point(337, 217);
            promedio_precios.Margin = new Padding(6, 0, 6, 0);
            promedio_precios.Name = "promedio_precios";
            promedio_precios.Size = new Size(219, 23);
            promedio_precios.TabIndex = 13;
            promedio_precios.Text = "Promedio de Precios:";
            // 
            // button6
            // 
            button6.Font = new Font("Arial Rounded MT Bold", 12F);
            button6.Location = new Point(629, 260);
            button6.Margin = new Padding(6, 5, 6, 5);
            button6.Name = "button6";
            button6.Size = new Size(185, 42);
            button6.TabIndex = 16;
            button6.Text = "Máximo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // precio_m
            // 
            precio_m.AutoSize = true;
            precio_m.Font = new Font("Arial Rounded MT Bold", 12F);
            precio_m.Location = new Point(629, 217);
            precio_m.Margin = new Padding(6, 0, 6, 0);
            precio_m.Name = "precio_m";
            precio_m.Size = new Size(79, 23);
            precio_m.TabIndex = 15;
            precio_m.Text = "Precio:";
            // 
            // button7
            // 
            button7.Font = new Font("Arial Rounded MT Bold", 12F);
            button7.Location = new Point(826, 260);
            button7.Margin = new Padding(6, 5, 6, 5);
            button7.Name = "button7";
            button7.Size = new Size(185, 42);
            button7.TabIndex = 17;
            button7.Text = "Mínimo";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Rounded MT Bold", 12F);
            button8.Location = new Point(300, 123);
            button8.Margin = new Padding(6, 5, 6, 5);
            button8.Name = "button8";
            button8.Size = new Size(205, 42);
            button8.TabIndex = 18;
            button8.Text = "Visualizar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(300, 80);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 19;
            label4.Text = "Vista Rápida:";
            // 
            // consultar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 666);
            Controls.Add(label4);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(precio_m);
            Controls.Add(button5);
            Controls.Add(promedio_precios);
            Controls.Add(button4);
            Controls.Add(suma_precios);
            Controls.Add(button3);
            Controls.Add(tableproductos);
            Controls.Add(id_producto);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "consultar";
            Text = "consultar";
            ((System.ComponentModel.ISupportInitialize)tableproductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox id_producto;
        private DataGridView tableproductos;
        private Button button3;
        private Button button4;
        private Label suma_precios;
        private Button button5;
        private Label promedio_precios;
        private Button button6;
        private Label precio_m;
        private Button button7;
        private Button button8;
        private Label label4;
    }
}