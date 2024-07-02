namespace asgardsclinic
{
    partial class Registro
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
            panelregistro = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Guardar = new FontAwesome.Sharp.IconButton();
            lblregistro = new Label();
            panelregistro.SuspendLayout();
            SuspendLayout();
            // 
            // panelregistro
            // 
            panelregistro.Controls.Add(textBox3);
            panelregistro.Controls.Add(textBox2);
            panelregistro.Controls.Add(textBox1);
            panelregistro.Controls.Add(label3);
            panelregistro.Controls.Add(label2);
            panelregistro.Controls.Add(label1);
            panelregistro.Controls.Add(Guardar);
            panelregistro.Controls.Add(lblregistro);
            panelregistro.Dock = DockStyle.Fill;
            panelregistro.Location = new Point(0, 0);
            panelregistro.Name = "panelregistro";
            panelregistro.Size = new Size(800, 450);
            panelregistro.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(389, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(258, 187);
            label3.Name = "label3";
            label3.Size = new Size(130, 22);
            label3.TabIndex = 8;
            label3.Text = "Especialidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(258, 140);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(258, 92);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // Guardar
            // 
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guardar.ForeColor = Color.Gainsboro;
            Guardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            Guardar.IconColor = Color.Gainsboro;
            Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Guardar.IconSize = 18;
            Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            Guardar.Location = new Point(317, 239);
            Guardar.Name = "Guardar";
            Guardar.Padding = new Padding(10, 0, 20, 0);
            Guardar.Size = new Size(130, 40);
            Guardar.TabIndex = 5;
            Guardar.Text = "Guardar ";
            Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Guardar.UseVisualStyleBackColor = true;
            // 
            // lblregistro
            // 
            lblregistro.AutoSize = true;
            lblregistro.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblregistro.ForeColor = Color.Gainsboro;
            lblregistro.Location = new Point(258, 30);
            lblregistro.Name = "lblregistro";
            lblregistro.Size = new Size(270, 30);
            lblregistro.TabIndex = 0;
            lblregistro.Text = "Bienvenido al registro";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 34, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(panelregistro);
            Name = "Registro";
            Text = "Registro";
            panelregistro.ResumeLayout(false);
            panelregistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelregistro;
        private Label lblregistro;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton Guardar;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}