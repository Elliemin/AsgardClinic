namespace asgardsclinic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelmenu = new Panel();
            Ajustes = new FontAwesome.Sharp.IconButton();
            Consultas = new FontAwesome.Sharp.IconButton();
            Pacientes = new FontAwesome.Sharp.IconButton();
            Medicos = new FontAwesome.Sharp.IconButton();
            Dashboard = new FontAwesome.Sharp.IconButton();
            panellogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            lblTitlechildform = new Label();
            iconCurrentchildform = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelmenu.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentchildform).BeginInit();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(31, 30, 68);
            panelmenu.Controls.Add(Ajustes);
            panelmenu.Controls.Add(Consultas);
            panelmenu.Controls.Add(Pacientes);
            panelmenu.Controls.Add(Medicos);
            panelmenu.Controls.Add(Dashboard);
            panelmenu.Controls.Add(panellogo);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(200, 519);
            panelmenu.TabIndex = 0;
            // 
            // Ajustes
            // 
            Ajustes.Dock = DockStyle.Top;
            Ajustes.FlatStyle = FlatStyle.Flat;
            Ajustes.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ajustes.ForeColor = Color.Gainsboro;
            Ajustes.IconChar = FontAwesome.Sharp.IconChar.Gear;
            Ajustes.IconColor = Color.Gainsboro;
            Ajustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ajustes.IconSize = 32;
            Ajustes.ImageAlign = ContentAlignment.MiddleLeft;
            Ajustes.Location = new Point(0, 280);
            Ajustes.Name = "Ajustes";
            Ajustes.Padding = new Padding(10, 0, 20, 0);
            Ajustes.Size = new Size(200, 40);
            Ajustes.TabIndex = 5;
            Ajustes.Text = "Ajustes";
            Ajustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ajustes.UseVisualStyleBackColor = true;
            Ajustes.Click += Ajustes_Click;
            // 
            // Consultas
            // 
            Consultas.Dock = DockStyle.Top;
            Consultas.FlatStyle = FlatStyle.Flat;
            Consultas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Consultas.ForeColor = Color.Gainsboro;
            Consultas.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            Consultas.IconColor = Color.Gainsboro;
            Consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Consultas.IconSize = 32;
            Consultas.ImageAlign = ContentAlignment.MiddleLeft;
            Consultas.Location = new Point(0, 240);
            Consultas.Name = "Consultas";
            Consultas.Padding = new Padding(10, 0, 20, 0);
            Consultas.Size = new Size(200, 40);
            Consultas.TabIndex = 4;
            Consultas.Text = "Consultas";
            Consultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            Consultas.UseVisualStyleBackColor = true;
            Consultas.Click += Consultas_Click;
            // 
            // Pacientes
            // 
            Pacientes.Dock = DockStyle.Top;
            Pacientes.FlatStyle = FlatStyle.Flat;
            Pacientes.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pacientes.ForeColor = Color.Gainsboro;
            Pacientes.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            Pacientes.IconColor = Color.Gainsboro;
            Pacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Pacientes.IconSize = 32;
            Pacientes.ImageAlign = ContentAlignment.MiddleLeft;
            Pacientes.Location = new Point(0, 200);
            Pacientes.Name = "Pacientes";
            Pacientes.Padding = new Padding(10, 0, 20, 0);
            Pacientes.Size = new Size(200, 40);
            Pacientes.TabIndex = 3;
            Pacientes.Text = "Pacientes";
            Pacientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Pacientes.UseVisualStyleBackColor = true;
            Pacientes.Click += Pacientes_Click;
            // 
            // Medicos
            // 
            Medicos.Dock = DockStyle.Top;
            Medicos.FlatStyle = FlatStyle.Flat;
            Medicos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Medicos.ForeColor = Color.Gainsboro;
            Medicos.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            Medicos.IconColor = Color.Gainsboro;
            Medicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Medicos.IconSize = 32;
            Medicos.ImageAlign = ContentAlignment.MiddleLeft;
            Medicos.Location = new Point(0, 160);
            Medicos.Name = "Medicos";
            Medicos.Padding = new Padding(10, 0, 20, 0);
            Medicos.Size = new Size(200, 40);
            Medicos.TabIndex = 2;
            Medicos.Text = "Medicos";
            Medicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            Medicos.UseVisualStyleBackColor = true;
            Medicos.Click += Medicos_Click;
            // 
            // Dashboard
            // 
            Dashboard.Dock = DockStyle.Top;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.Gainsboro;
            Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChalkboardUser;
            Dashboard.IconColor = Color.Gainsboro;
            Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Dashboard.IconSize = 32;
            Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard.Location = new Point(0, 120);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(10, 0, 20, 0);
            Dashboard.Size = new Size(200, 40);
            Dashboard.TabIndex = 1;
            Dashboard.Text = "Dashboard";
            Dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashboard.UseVisualStyleBackColor = true;
            Dashboard.Click += Dashboard_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(btnHome);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(200, 120);
            panellogo.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.Black_Modern_Physiotherapist_Logo_removebg_preview21512;
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(176, 94);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(lblTitlechildform);
            panelTitleBar.Controls.Add(iconCurrentchildform);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(200, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(777, 80);
            panelTitleBar.TabIndex = 2;
            // 
            // lblTitlechildform
            // 
            lblTitlechildform.AutoSize = true;
            lblTitlechildform.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitlechildform.ForeColor = Color.Gainsboro;
            lblTitlechildform.Location = new Point(56, 43);
            lblTitlechildform.Name = "lblTitlechildform";
            lblTitlechildform.Size = new Size(47, 17);
            lblTitlechildform.TabIndex = 3;
            lblTitlechildform.Text = "Home";
            // 
            // iconCurrentchildform
            // 
            iconCurrentchildform.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentchildform.ForeColor = Color.MediumSlateBlue;
            iconCurrentchildform.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentchildform.IconColor = Color.MediumSlateBlue;
            iconCurrentchildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentchildform.Location = new Point(18, 33);
            iconCurrentchildform.Name = "iconCurrentchildform";
            iconCurrentchildform.Size = new Size(32, 32);
            iconCurrentchildform.TabIndex = 0;
            iconCurrentchildform.TabStop = false;
            iconCurrentchildform.Click += iconPictureBox1_Click;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(200, 80);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(777, 9);
            panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(33, 34, 73);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(200, 89);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(777, 430);
            panelDesktop.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 519);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelmenu);
            Name = "Form1";
            Text = "Form1";
            panelmenu.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentchildform).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenu;
        private Panel panellogo;
        private PictureBox btnHome;
        private FontAwesome.Sharp.IconButton Dashboard;
        private FontAwesome.Sharp.IconButton Ajustes;
        private FontAwesome.Sharp.IconButton Consultas;
        private FontAwesome.Sharp.IconButton Pacientes;
        private FontAwesome.Sharp.IconButton Medicos;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentchildform;
        private Label lblTitlechildform;
        private Panel panelShadow;
        private Panel panelDesktop;
    }
}
