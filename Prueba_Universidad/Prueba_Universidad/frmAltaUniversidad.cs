using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_Universidad;

namespace Prueba_universidad
{
    public partial class frmAltaUniversidad : Form
    {
        public frmAltaUniversidad()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Compartir.objUni =new Universidad();
            Compartir.objUni.P_nombre = txtNombre.Text;
            Compartir.objUni.P_direccion = txtDireccion.Text;
            Compartir.objUni.P_telefono = txtTelefono.Text;
            Compartir.objUni.P_fc = dtpFecha.Value;
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFecha.Value = DateTime.Now;

            MessageBox.Show("La Universidad ha sido dada de alta");
         
        }

        private void frmAltaUniversidad_Load(object sender, EventArgs e)
        {

        }
    }
}
