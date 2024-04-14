namespace tiendita
{
    partial class agregar
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            button1 = new Button();
            nombre_producto = new TextBox();
            descripcion_producto = new TextBox();
            precio_producto = new TextBox();
            stock_producto = new TextBox();
            categoria_producto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 18);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 46);
            label1.TabIndex = 2;
            label1.Text = "Agregar productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(41, 101);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(430, 101);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 5;
            label2.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(846, 101);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(41, 257);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 7;
            label5.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(430, 257);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 8;
            label6.Text = "Categoria:";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.Location = new Point(275, 414);
            button3.Margin = new Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new Size(259, 42);
            button3.TabIndex = 11;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.Location = new Point(589, 414);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(259, 42);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nombre_producto
            // 
            nombre_producto.Location = new Point(32, 138);
            nombre_producto.Name = "nombre_producto";
            nombre_producto.Size = new Size(310, 27);
            nombre_producto.TabIndex = 13;
            // 
            // descripcion_producto
            // 
            descripcion_producto.Location = new Point(430, 138);
            descripcion_producto.Name = "descripcion_producto";
            descripcion_producto.Size = new Size(310, 27);
            descripcion_producto.TabIndex = 14;
            // 
            // precio_producto
            // 
            precio_producto.Location = new Point(846, 138);
            precio_producto.Name = "precio_producto";
            precio_producto.Size = new Size(310, 27);
            precio_producto.TabIndex = 15;
            // 
            // stock_producto
            // 
            stock_producto.Location = new Point(32, 298);
            stock_producto.Name = "stock_producto";
            stock_producto.Size = new Size(310, 27);
            stock_producto.TabIndex = 16;
            // 
            // categoria_producto
            // 
            categoria_producto.Location = new Point(430, 298);
            categoria_producto.Name = "categoria_producto";
            categoria_producto.Size = new Size(310, 27);
            categoria_producto.TabIndex = 17;
            // 
            // agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 496);
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
            Name = "agregar";
            Text = "agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button1;
        private TextBox nombre_producto;
        private TextBox descripcion_producto;
        private TextBox precio_producto;
        private TextBox stock_producto;
        private TextBox categoria_producto;
    }
}