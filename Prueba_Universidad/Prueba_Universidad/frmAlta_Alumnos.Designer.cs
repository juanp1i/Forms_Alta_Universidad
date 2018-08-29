namespace Prueba_Universidad
{
    partial class frmAlta_Alumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtNombre_alumno = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAgregarA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(160, 57);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 3;
            // 
            // txtNombre_alumno
            // 
            this.txtNombre_alumno.Location = new System.Drawing.Point(160, 135);
            this.txtNombre_alumno.Name = "txtNombre_alumno";
            this.txtNombre_alumno.Size = new System.Drawing.Size(100, 20);
            this.txtNombre_alumno.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnAgregarA
            // 
            this.btnAgregarA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarA.Location = new System.Drawing.Point(0, 396);
            this.btnAgregarA.Name = "btnAgregarA";
            this.btnAgregarA.Size = new System.Drawing.Size(800, 54);
            this.btnAgregarA.TabIndex = 6;
            this.btnAgregarA.Text = "Agregar";
            this.btnAgregarA.UseVisualStyleBackColor = true;
            // 
            // frmAlta_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarA);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre_alumno);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlta_Alumnos";
            this.Text = "Alta de alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtNombre_alumno;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAgregarA;
    }
}