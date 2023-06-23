
namespace AdministradorParqueo
{
    partial class Registrar
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
            this.LblContrasena = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomLocal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Location = new System.Drawing.Point(73, 111);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(70, 15);
            this.LblContrasena.TabIndex = 8;
            this.LblContrasena.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(73, 45);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 15);
            this.LblUsuario.TabIndex = 7;
            this.LblUsuario.Text = "Usuario:";
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(73, 129);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PlaceholderText = "Ingrese su contraseña";
            this.TxtContrasena.Size = new System.Drawing.Size(252, 23);
            this.TxtContrasena.TabIndex = 6;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(73, 66);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PlaceholderText = "Ingrese su usuario";
            this.TxtUsuario.Size = new System.Drawing.Size(252, 23);
            this.TxtUsuario.TabIndex = 5;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrar.Location = new System.Drawing.Point(211, 254);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 9;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSalir.Location = new System.Drawing.Point(113, 254);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Cancelar";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Local:";
            // 
            // TxtNomLocal
            // 
            this.TxtNomLocal.Location = new System.Drawing.Point(73, 189);
            this.TxtNomLocal.Name = "TxtNomLocal";
            this.TxtNomLocal.PlaceholderText = "Ingrese el nombre de su local";
            this.TxtNomLocal.Size = new System.Drawing.Size(252, 23);
            this.TxtNomLocal.TabIndex = 11;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 337);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomLocal);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomLocal;
    }
}