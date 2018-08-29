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
    public partial class Mostrar_todos : Form
    { 
        public Mostrar_todos()
        {
            InitializeComponent();
        }

        private void Mostrar_todos_Load(object sender, EventArgs e)
        {
            try
            {
                lblUniversidad.Text = Compartir.objUni.P_nombre;
                lblDirec_Uni.Text = Compartir.objUni.P_direccion;
                lblTelefono.Text = Compartir.objUni.P_telefono;
                for (int x = 0; x < Compartir.objUni.P_pos; x++)
                {
                    ListViewItem item;
                    item = lvAlumnos.Items.Add(Compartir.objUni.P_estudiantes[x].P_registro);
                    item.SubItems.Add(Compartir.objUni.P_estudiantes[x].P_nombre);
                    item.SubItems.Add(Compartir.objUni.P_estudiantes[x].P_correo);
                    item.SubItems.Add(Compartir.objUni.P_estudiantes[x].promedio().ToString());
                }
            }
            catch(Exception exe)
            {
                 MessageBox.Show(exe.Message);
            }
            
        }

        private void lvAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
