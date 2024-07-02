namespace asgardsclinic
{
    partial class Pacientesnoinfo
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
            label10 = new Label();
            label11 = new Label();
            label3 = new Label();
            lblnombremedico = new Label();
            lblhora = new Label();
            lblfechamedica = new Label();
            lblnombrepaciente = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(151, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre del paciente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(12, 107);
            label10.Name = "label10";
            label10.Size = new Size(51, 17);
            label10.TabIndex = 10;
            label10.Text = "Fecha:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(12, 127);
            label11.Name = "label11";
            label11.Size = new Size(43, 17);
            label11.TabIndex = 11;
            label11.Text = "Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 12;
            label3.Text = "Medico:";
            // 
            // lblnombremedico
            // 
            lblnombremedico.AutoSize = true;
            lblnombremedico.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombremedico.ForeColor = Color.Gainsboro;
            lblnombremedico.Location = new Point(78, 84);
            lblnombremedico.Name = "lblnombremedico";
            lblnombremedico.Size = new Size(0, 17);
            lblnombremedico.TabIndex = 13;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhora.ForeColor = Color.Gainsboro;
            lblhora.Location = new Point(61, 127);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(0, 17);
            lblhora.TabIndex = 14;
            // 
            // lblfechamedica
            // 
            lblfechamedica.AutoSize = true;
            lblfechamedica.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfechamedica.ForeColor = Color.Gainsboro;
            lblfechamedica.Location = new Point(69, 107);
            lblfechamedica.Name = "lblfechamedica";
            lblfechamedica.Size = new Size(0, 17);
            lblfechamedica.TabIndex = 15;
            // 
            // lblnombrepaciente
            // 
            lblnombrepaciente.AutoSize = true;
            lblnombrepaciente.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombrepaciente.ForeColor = Color.Gainsboro;
            lblnombrepaciente.Location = new Point(168, 61);
            lblnombrepaciente.Name = "lblnombrepaciente";
            lblnombrepaciente.Size = new Size(0, 17);
            lblnombrepaciente.TabIndex = 16;
            // 
            // Pacientesnoinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 34, 73);
            ClientSize = new Size(397, 450);
            Controls.Add(lblnombrepaciente);
            Controls.Add(lblfechamedica);
            Controls.Add(lblhora);
            Controls.Add(lblnombremedico);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pacientesnoinfo";
            Text = "Pacientesnoinfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label3;
        private Label lblnombremedico;
        private Label lblhora;
        private Label lblfechamedica;
        private Label lblnombrepaciente;
    }
}