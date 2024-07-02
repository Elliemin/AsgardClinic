using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asgardsclinic
{
    public partial class AgendarCita : Form
    {
        public AgendarCita()
        {
            InitializeComponent();
        }


        //Cambia el color del boton al pasar el mouse por encima de el
        //Para que el boton funcione debes conectarlo con las lista que guarda los datos del paciente
        //así al dar clic sobre el boton este tendra una funcion xd 
        private void Guardar_Click(object sender, EventArgs e)
        {
            Button.DefaultBackColor = Brushes.Green;
        }
    }
}
