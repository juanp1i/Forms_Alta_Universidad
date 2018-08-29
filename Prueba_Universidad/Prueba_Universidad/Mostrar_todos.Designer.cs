namespace Prueba_universidad
{
    partial class Mostrar_todos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAlumnos = new System.Windows.Forms.ListView();
            this.chRegistro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAlumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPromedio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.lblDirec_Uni = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAlumnos
            // 
            this.lvAlumnos.BackColor = System.Drawing.Color.LightGreen;
            this.lvAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRegistro,
            this.chAlumno,
            this.chEmail,
            this.chPromedio});
            this.lvAlumnos.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAlumnos.ForeColor = System.Drawing.Color.Black;
            this.lvAlumnos.GridLines = true;
            this.lvAlumnos.Location = new System.Drawing.Point(35, 115);
            this.lvAlumnos.Name = "lvAlumnos";
            this.lvAlumnos.Size = new System.Drawing.Size(732, 293);
            this.lvAlumnos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAlumnos.TabIndex = 2;
            this.lvAlumnos.UseCompatibleStateImageBehavior = false;
            this.lvAlumnos.View = System.Windows.Forms.View.Details;
            this.lvAlumnos.SelectedIndexChanged += new System.EventHandler(this.lvAlumnos_SelectedIndexChanged);
            // 
            // chRegistro
            // 
            this.chRegistro.Text = "Registro del Alumno";
            this.chRegistro.Width = 153;
            // 
            // chAlumno
            // 
            this.chAlumno.Text = "Alumno";
            this.chAlumno.Width = 223;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email del alumno";
            this.chEmail.Width = 185;
            // 
            // chPromedio
            // 
            this.chPromedio.Text = "Promedio del alumno";
            this.chPromedio.Width = 166;
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Location = new System.Drawing.Point(94, 35);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(139, 13);
            this.lblUniversidad.TabIndex = 3;
            this.lblUniversidad.Text = "______________________";
            // 
            // lblDirec_Uni
            // 
            this.lblDirec_Uni.AutoSize = true;
            this.lblDirec_Uni.Location = new System.Drawing.Point(310, 35);
            this.lblDirec_Uni.Name = "lblDirec_Uni";
            this.lblDirec_Uni.Size = new System.Drawing.Size(163, 13);
            this.lblDirec_Uni.TabIndex = 4;
            this.lblDirec_Uni.Text = "__________________________";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(548, 35);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(127, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "____________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Universidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblDirec_Uni);
            this.groupBox1.Controls.Add(this.lblUniversidad);
            this.groupBox1.Location = new System.Drawing.Point(57, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales de la Universidad";
            // 
            // Mostrar_todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvAlumnos);
            this.Name = "Mostrar_todos";
            this.Text = "Mostrar_todos";
            this.Load += new System.EventHandler(this.Mostrar_todos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAlumnos;
        private System.Windows.Forms.ColumnHeader chRegistro;
        private System.Windows.Forms.ColumnHeader chAlumno;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chPromedio;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Label lblDirec_Uni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}