namespace tiendita
{
    partial class trigger
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
            id_producto = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // id_producto
            // 
            id_producto.Location = new Point(15, 139);
            id_producto.Name = "id_producto";
            id_producto.Size = new Size(286, 27);
            id_producto.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F);
            button2.Location = new Point(310, 129);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(176, 42);
            button2.TabIndex = 11;
            button2.Text = "Incrementar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(15, 95);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 23);
            label2.TabIndex = 10;
            label2.Text = "Consulta específica:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(421, 46);
            label1.TabIndex = 9;
            label1.Text = "Consultar productos";
            // 
            // trigger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id_producto);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "trigger";
            Text = "trigger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id_producto;
        private Button button2;
        private Label label2;
        private Label label1;
    }
}