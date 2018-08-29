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
    public partial class frmAltaAlumnos : Form
    {
        public frmAltaAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Compartir.objEst = new Estudiante(txtNombre.Text,txtEmail.Text,txtRegistro.Text,Convert.ToInt32(cmbNotas.Text));
                string mensaje = Compartir.objUni.llenar_estudiantes(Compartir.objEst);
                if (mensaje == "")
                {
                    txtNombre.Text = "";
                    txtEmail.Text = "";
                    txtRegistro.Text = "";
                    cmbNotas.Text = "";
                    frmNotas Ventana = new frmNotas();
                    AddOwnedForm(Ventana);
                    Ventana.ShowDialog();
                    if (Ventana == AcceptButton)
                        Ventana.Close();
                }
                else
                    MessageBox.Show(mensaje);
            }
            catch(Exception)
            {
                MessageBox.Show("Primero debes dar de alta una universidad");
            }
        }

        private void frmAltaAlumnos_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
                cmbNotas.Items.Add(i);
        }
    }
}
