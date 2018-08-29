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

namespace Prueba_Universidad
{
    public partial class frmAlta_Universidad : Form
    {
        public frmAlta_Universidad()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Compartir.objUNI = new UNIVERSIDAD();
            Compartir.objUNI.P_nombre = txtNombre.Text;
            Compartir.objUNI.P_direccion = txtDireccion.Text;
            Compartir.objUNI.P_telefono = txtTelefono.Text;
            Compartir.objUNI.P_fecha_creacion = dtpFecha.Value;
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFecha.Value = DateTime.Now;
            MessageBox.Show("La universidad ha sido dada de alta");
        }
    }
}
