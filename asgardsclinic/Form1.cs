using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace asgardsclinic
{
    public partial class Form1 : Form
    {
        //Declaración del campo de forma privada para almacenar el boton actual y un panel para un borde izquierdo al boton 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentchildform; //formulario hijo actual

        // Constructor e inicializa el panel izquierdo del boton
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelmenu.Controls.Add(leftBorderBtn);
        }

        //Almacena una cantidad de colores RGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(95, 77, 221);
        }

        //Metodos
        // 1 privado de tipo vacio para resaltar el boton activo como subparametro del boton remitente y un color
        private void ActivateButton(object senderBtn, Color color)
        {
            //Condicion para verificar que el boton sea diferente a nulo 
            if (senderBtn != null)
            {

                DisableButton();
                //Botones Bonitos :3
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Panel izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icono hijo Home
                iconCurrentchildform.IconChar = currentBtn.IconChar;
                iconCurrentchildform.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Funcion para el formulario hijo actual 
        private void OpenChildform (Form childForm)
        {
          if (currentchildform != null) 
            {
                //En dado caso asi solo se abre un formulario, es decir se cierra el formulario anterior
                currentchildform.Close();
            }
            currentchildform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitlechildform.Text = childForm.Text;
        }

        // Eventos al momento de dar click en cada boton
        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildform(new FormDashboard());
        }

        private void Medicos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildform(new FormMedicos());
        }

        private void Pacientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildform(new FormPacientes());
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildform(new FormConsultas());
        }

        private void Ajustes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildform(new FormAjustes());
        }


        //Al dar click en el logo se reinician los botones (aun no funciona correctamente ojito) 
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            leftBorderBtn.Visible = false;
            iconCurrentchildform.IconChar = IconChar.Home;
            iconCurrentchildform.IconColor = Color.MediumSlateBlue;
            lblTitlechildform.Text = "Home";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}



        


