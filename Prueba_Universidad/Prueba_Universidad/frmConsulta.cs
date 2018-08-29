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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            for(int x=0;x<Compartir.objUni.P_pos;x++)
                cmbNombre.Items.Add(Compartir.objUni.P_estudiantes[x].P_nombre);
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEmail.Text = Compartir.objUni.buscar_correo(cmbNombre.Text);
            lblPromedio.Text = Compartir.objUni.buscar_promedio(cmbNombre.Text).ToString();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbNombre.Items.Clear();
            for (int x = 0; x < Compartir.objUni.P_pos; x++)
                cmbNombre.Items.Add(Compartir.objUni.P_estudiantes[x].P_nombre);
        }
    }
}
