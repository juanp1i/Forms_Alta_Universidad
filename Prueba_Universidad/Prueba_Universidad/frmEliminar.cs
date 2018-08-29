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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < Compartir.objUni.P_pos; x++)
                cmbNombre.Items.Add(Compartir.objUni.P_estudiantes[x].P_nombre);
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Eliminar estudiante", "¿Desea eliminar al estudiante?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
                Compartir.objUni.Eliminar(cmbNombre.SelectedIndex);
            else
                MessageBox.Show("Eliminación cancelada!");
            cmbNombre.Items.Clear();
            for (int x = 0; x < Compartir.objUni.P_pos; x++)
                cmbNombre.Items.Add(Compartir.objUni.P_estudiantes[x].P_nombre);
        }
    }
}
