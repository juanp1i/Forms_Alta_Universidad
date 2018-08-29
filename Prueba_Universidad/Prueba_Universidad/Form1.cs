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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tsMensaje.Text = "programa de captura de estudiantes";
            tsFecha.Text = DateTime.Now.Date.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtHora = DateTime.Now;
            tsHora.Text = dtHora.ToString("h:m:s");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsMensaje.Text = "Alta de Universidad";
            frmAltaUniversidad ventana = new frmAltaUniversidad();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsMensaje.Text = "Alta de Estudiantes";
            frmAltaAlumnos ventana = new frmAltaAlumnos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsMensaje.Text = "Consulta de Estudiantes";
            frmConsulta ventana = new frmConsulta();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsMensaje.Text = "Eliminar Alumnos";
            frmEliminar ventana = new frmEliminar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsMensaje.Text = "Mostrar todos los registros";
            Mostrar_todos ventana = new Mostrar_todos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void universidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
