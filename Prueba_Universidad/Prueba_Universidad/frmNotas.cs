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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Compartir.objN = new Nota(txtMateria.Text, Convert.ToDouble(txtCalificacion.Text));
                string mensaje = Compartir.objEst.llenar_notas(Compartir.objN,Compartir.objEst.p_tamaño);
                if (mensaje == "")
                {
                    txtMateria.Text = "";
                    txtCalificacion.Text = "";
                    txtMateria.Focus();
                    MessageBox.Show("Agregado");
                }
                else
                {
                    MessageBox.Show(mensaje);
                    this.Close();
                }
            }
            catch (Exception j)
            {
                MessageBox.Show(j.Message);
            }
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
