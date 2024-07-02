namespace asgardsclinic
{
    partial class FormMedicos
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
            menuStrip1 = new MenuStrip();
            listaToolStripMenuItem = new ToolStripMenuItem();
            listaDeMédicosToolStripMenuItem = new ToolStripMenuItem();
            detallesToolStripMenuItem = new ToolStripMenuItem();
            medicosDetallesToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            Eliminarl = new DataGridViewImageColumn();
            Eliminar = new FontAwesome.Sharp.IconButton();
            Modificar = new FontAwesome.Sharp.IconButton();
            Añadir = new FontAwesome.Sharp.IconButton();
            Search = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            lblListaMedicos = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { listaToolStripMenuItem, detallesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeMédicosToolStripMenuItem });
            listaToolStripMenuItem.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(48, 21);
            listaToolStripMenuItem.Text = "Lista";
            // 
            // listaDeMédicosToolStripMenuItem
            // 
            listaDeMédicosToolStripMenuItem.Name = "listaDeMédicosToolStripMenuItem";
            listaDeMédicosToolStripMenuItem.Size = new Size(182, 22);
            listaDeMédicosToolStripMenuItem.Text = "Lista de Médicos";
            // 
            // detallesToolStripMenuItem
            // 
            detallesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicosDetallesToolStripMenuItem });
            detallesToolStripMenuItem.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            detallesToolStripMenuItem.Size = new Size(71, 21);
            detallesToolStripMenuItem.Text = "Detalles";
            // 
            // medicosDetallesToolStripMenuItem
            // 
            medicosDetallesToolStripMenuItem.Name = "medicosDetallesToolStripMenuItem";
            medicosDetallesToolStripMenuItem.Size = new Size(188, 22);
            medicosDetallesToolStripMenuItem.Text = "Medicos Detalles ";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(Modificar);
            panel1.Controls.Add(Añadir);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblListaMedicos);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 401);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, Nombre, Apellido, Especialidad, Editar, Eliminarl });
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(586, 326);
            dataGridView1.TabIndex = 7;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad ";
            Especialidad.Name = "Especialidad";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            // 
            // Eliminarl
            // 
            Eliminarl.HeaderText = "Eliminar";
            Eliminarl.Name = "Eliminarl";
            // 
            // Eliminar
            // 
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Eliminar.ForeColor = Color.Gainsboro;
            Eliminar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            Eliminar.IconColor = Color.Gainsboro;
            Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Eliminar.IconSize = 18;
            Eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            Eliminar.Location = new Point(618, 176);
            Eliminar.Name = "Eliminar";
            Eliminar.Padding = new Padding(10, 0, 20, 0);
            Eliminar.Size = new Size(130, 40);
            Eliminar.TabIndex = 6;
            Eliminar.Text = "Eliminar";
            Eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Eliminar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            Modificar.FlatStyle = FlatStyle.Flat;
            Modificar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Modificar.ForeColor = Color.Gainsboro;
            Modificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            Modificar.IconColor = Color.Gainsboro;
            Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Modificar.IconSize = 18;
            Modificar.ImageAlign = ContentAlignment.MiddleLeft;
            Modificar.Location = new Point(618, 119);
            Modificar.Name = "Modificar";
            Modificar.Padding = new Padding(10, 0, 20, 0);
            Modificar.Size = new Size(130, 40);
            Modificar.TabIndex = 5;
            Modificar.Text = "Modificar";
            Modificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // Añadir
            // 
            Añadir.FlatStyle = FlatStyle.Flat;
            Añadir.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Añadir.ForeColor = Color.Gainsboro;
            Añadir.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            Añadir.IconColor = Color.Gainsboro;
            Añadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Añadir.IconSize = 18;
            Añadir.ImageAlign = ContentAlignment.MiddleLeft;
            Añadir.Location = new Point(618, 63);
            Añadir.Name = "Añadir";
            Añadir.Padding = new Padding(10, 0, 20, 0);
            Añadir.Size = new Size(130, 40);
            Añadir.TabIndex = 4;
            Añadir.Text = "Añadir";
            Añadir.TextImageRelation = TextImageRelation.ImageBeforeText;
            Añadir.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.FlatStyle = FlatStyle.Flat;
            Search.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search.ForeColor = Color.Gainsboro;
            Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            Search.IconColor = Color.Gainsboro;
            Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Search.IconSize = 18;
            Search.ImageAlign = ContentAlignment.MiddleLeft;
            Search.Location = new Point(487, 31);
            Search.Name = "Search";
            Search.Padding = new Padding(10, 0, 20, 0);
            Search.Size = new Size(111, 23);
            Search.TabIndex = 2;
            Search.Text = "Buscar";
            Search.TextImageRelation = TextImageRelation.ImageBeforeText;
            Search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 23);
            textBox1.TabIndex = 1;
            // 
            // lblListaMedicos
            // 
            lblListaMedicos.AutoSize = true;
            lblListaMedicos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaMedicos.ForeColor = Color.Gainsboro;
            lblListaMedicos.Location = new Point(12, 11);
            lblListaMedicos.Name = "lblListaMedicos";
            lblListaMedicos.Size = new Size(114, 17);
            lblListaMedicos.TabIndex = 0;
            lblListaMedicos.Text = "Lista de Médicos";
            // 
            // FormMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 34, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMedicos";
            Text = "FormMedicos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem listaDeMédicosToolStripMenuItem;
        private ToolStripMenuItem detallesToolStripMenuItem;
        private ToolStripMenuItem medicosDetallesToolStripMenuItem;
        private Panel panel1;
        private TextBox textBox1;
        private Label lblListaMedicos;
        private FontAwesome.Sharp.IconButton Search;
        private FontAwesome.Sharp.IconButton Añadir;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton Modificar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminarl;
    }
}