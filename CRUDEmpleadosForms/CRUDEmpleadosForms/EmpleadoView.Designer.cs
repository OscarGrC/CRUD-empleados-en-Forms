namespace CRUDEmpleadosForms
{
    partial class EmpleadoView
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNombre = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxPuesto = new TextBox();
            textBoxDNI = new TextBox();
            textBoxCorreo = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombe";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 10);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 10);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Puesto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 54);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 54);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 5;
            label6.Text = "Departamento";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(3, 28);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(161, 23);
            textBoxNombre.TabIndex = 6;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(196, 72);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(161, 23);
            textBoxTelefono.TabIndex = 7;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // textBoxPuesto
            // 
            textBoxPuesto.Location = new Point(383, 28);
            textBoxPuesto.Name = "textBoxPuesto";
            textBoxPuesto.Size = new Size(161, 23);
            textBoxPuesto.TabIndex = 8;
            textBoxPuesto.TextChanged += textBoxPuesto_TextChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(0, 72);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(161, 23);
            textBoxDNI.TabIndex = 9;
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(196, 28);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(161, 23);
            textBoxCorreo.TabIndex = 10;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBoxDNI);
            panel1.Controls.Add(textBoxCorreo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxTelefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPuesto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 110);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(383, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(37, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(234, 116);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(426, 116);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmpleadoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 144);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "EmpleadoView";
            Text = "Empleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNombre;
        private TextBox textBoxTelefono;
        private TextBox textBoxPuesto;
        private TextBox textBoxDNI;
        private TextBox textBoxCorreo;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
    }
}