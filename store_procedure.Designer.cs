namespace tiendita
{
    partial class store_procedure
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
            categoria_producto = new TextBox();
            stock_producto = new TextBox();
            precio_producto = new TextBox();
            descripcion_producto = new TextBox();
            nombre_producto = new TextBox();
            button1 = new Button();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // categoria_producto
            // 
            categoria_producto.Location = new Point(423, 285);
            categoria_producto.Name = "categoria_producto";
            categoria_producto.Size = new Size(310, 27);
            categoria_producto.TabIndex = 30;
            // 
            // stock_producto
            // 
            stock_producto.Location = new Point(25, 285);
            stock_producto.Name = "stock_producto";
            stock_producto.Size = new Size(310, 27);
            stock_producto.TabIndex = 29;
            // 
            // precio_producto
            // 
            precio_producto.Location = new Point(839, 125);
            precio_producto.Name = "precio_producto";
            precio_producto.Size = new Size(310, 27);
            precio_producto.TabIndex = 28;
            // 
            // descripcion_producto
            // 
            descripcion_producto.Location = new Point(423, 125);
            descripcion_producto.Name = "descripcion_producto";
            descripcion_producto.Size = new Size(310, 27);
            descripcion_producto.TabIndex = 27;
            // 
            // nombre_producto
            // 
            nombre_producto.Location = new Point(25, 125);
            nombre_producto.Name = "nombre_producto";
            nombre_producto.Size = new Size(310, 27);
            nombre_producto.TabIndex = 26;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.Location = new Point(582, 401);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(259, 42);
            button1.TabIndex = 25;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.Location = new Point(268, 401);
            button3.Margin = new Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new Size(259, 42);
            button3.TabIndex = 24;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(423, 244);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 23;
            label6.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(34, 244);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 22;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(839, 88);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 21;
            label4.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(423, 88);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 20;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(34, 88);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 19;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 5);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 46);
            label1.TabIndex = 18;
            label1.Text = "Agregar productos";
            // 
            // store_procedure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 472);
            Controls.Add(categoria_producto);
            Controls.Add(stock_producto);
            Controls.Add(precio_producto);
            Controls.Add(descripcion_producto);
            Controls.Add(nombre_producto);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "store_procedure";
            Text = "store_procedure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox categoria_producto;
        private TextBox stock_producto;
        private TextBox precio_producto;
        private TextBox descripcion_producto;
        private TextBox nombre_producto;
        private Button button1;
        private Button button3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}