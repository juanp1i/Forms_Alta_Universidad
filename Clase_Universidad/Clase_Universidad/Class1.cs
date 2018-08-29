using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Universidad
{
    public class Nota
    {
        private string materia;
        private double calificacion;

        public string P_materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public double P_cali
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public Nota()
        {
            materia = "";
            calificacion = 5;
        }

        public Nota(string m, double c)
        {
            materia = m;
            calificacion = c;
        }
    }



    public class Estudiante
    {
        private string nombre, correo, registro;
        private Nota[] Notas;
        private int pos = 0;
        private int tamaño;

        public int p_tamaño { get; set; }
        public string P_nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string P_correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string P_registro
        {
            get { return registro; }
            set { registro = value; }
        }

        public Nota[] P_notas
        {
            get { return Notas; }
        }

        public int P_pos
        {
            get { return pos; }
        }

        public Estudiante()
        {
            nombre = "";
            correo = "";
            registro = "";
            tamaño = 0;
            Notas = new Nota[5];
        }

        public Estudiante(string n, string co, string r, int t)
        {
            nombre = n;
            correo = co;
            registro = r;
            tamaño = t;
            Notas = new Nota[t];
        }

        public string llenar_notas(Nota n,int tam)
        {

            string m = "";
            try
            {
                Notas[pos] = new Nota();
                Notas[pos].P_materia = n.P_materia;
                Notas[pos].P_cali = n.P_cali;
                pos++;
            }
            catch (Exception)
            {
                m = "Notas completas";
            }
            return m;
            //string m = "";
            //if (pos <= tam)
            //{
            //    
            //}
            //else
            //    m = "Completado"; 
            //return m;
        }
        public double promedio()
        {
            double prom = 0;
            for (int i = 0; i < pos; i++)
                prom = prom + Notas[i].P_cali;
            prom = prom / pos;
            return prom;
        }
    }



    public class Universidad
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private DateTime fecha_creacion;
        private Estudiante[] estudiantes;
        private int pos = 0;

        public string P_nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string P_direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string P_telefono
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime P_fc
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }
        public Estudiante[] P_estudiantes
        {
            get { return estudiantes; }
        }
        public int P_pos
        {
            get { return pos; }
        }

        public Universidad()
        {
            nombre = "";
            telefono = "";
            direccion = "";
            fecha_creacion = DateTime.Now;
            estudiantes=new Estudiante[5];
        }
        public Universidad(string n, string te, string d, DateTime fc, int t)
        {
            nombre = n;
            telefono = te;
            direccion = d;
            fecha_creacion = fc;
            estudiantes = new Estudiante[t];
        }

        public string llenar_estudiantes(Estudiante e)
        {
            string m = "";
            try
            {
                estudiantes[pos] = e;
                pos++;
            }
            catch(Exception)
            {
                m = "Numero de estudiantes completo";
            }
            return m;
        }
        public string buscar_correo(string n)
        {
            for (int i = 0; i < pos; i++)
                if (n.Equals(estudiantes[i].P_nombre))
                    return estudiantes[i].P_correo;
            return null;
        }
        public double buscar_promedio(string n)
        {
            for (int i = 0; i < pos; i++)
                if (n.Equals(estudiantes[i].P_nombre))
                    return estudiantes[i].promedio();
            return 0;
        }
        public void Eliminar(int p)
        {
            if (p == 0 && pos == 1)
                pos = 0;
            if (p == pos - 1)
                pos--;
            else
            {
                for (int i = p; i < pos - 1; i++)
                    estudiantes[i] = estudiantes[i + 1];
                pos--;
            }
        }
    }
    public class Compartir
    {
        public static Universidad objUni;
        public static Estudiante objEst;
        public static Nota objN;
    }
}
        

