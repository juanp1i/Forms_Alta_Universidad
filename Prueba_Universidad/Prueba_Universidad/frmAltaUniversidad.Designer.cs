namespace Prueba_universidad
{
    partial class frmAltaUniversidad
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
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.lblDirecUni = new System.Windows.Forms.Label();
            this.lblTelUni = new System.Windows.Forms.Label();
            this.lblFCUni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Location = new System.Drawing.Point(78, 58);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(47, 13);
            this.lblUniversidad.TabIndex = 0;
            this.lblUniversidad.Text = "Nombre:";
            // 
            // lblDirecUni
            // 
            this.lblDirecUni.AutoSize = true;
            this.lblDirecUni.Location = new System.Drawing.Point(78, 106);
            this.lblDirecUni.Name = "lblDirecUni";
            this.lblDirecUni.Size = new System.Drawing.Size(55, 13);
            this.lblDirecUni.TabIndex = 1;
            this.lblDirecUni.Text = "Direccion:";
            // 
            // lblTelUni
            // 
            this.lblTelUni.AutoSize = true;
            this.lblTelUni.Location = new System.Drawing.Point(78, 158);
            this.lblTelUni.Name = "lblTelUni";
            this.lblTelUni.Size = new System.Drawing.Size(52, 13);
            this.lblTelUni.TabIndex = 2;
            this.lblTelUni.Text = "Telefono:";
            // 
            // lblFCUni
            // 
            this.lblFCUni.AutoSize = true;
            this.lblFCUni.Location = new System.Drawing.Point(78, 211);
            this.lblFCUni.Name = "lblFCUni";
            this.lblFCUni.Size = new System.Drawing.Size(99, 13);
            this.lblFCUni.TabIndex = 3;
            this.lblFCUni.Text = "Fecha de creacion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(216, 99);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(175, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(216, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(216, 205);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(229, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(198, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAltaUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFCUni);
            this.Controls.Add(this.lblTelUni);
            this.Controls.Add(this.lblDirecUni);
            this.Controls.Add(this.lblUniversidad);
            this.Name = "frmAltaUniversidad";
            this.Text = "Alta de Universidad";
            this.Load += new System.EventHandler(this.frmAltaUniversidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Label lblUniversidad;
        public System.Windows.Forms.Label lblDirecUni;
        public System.Windows.Forms.Label lblTelUni;
        public System.Windows.Forms.Label lblFCUni;
    }
}