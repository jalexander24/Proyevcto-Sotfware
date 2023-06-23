
namespace AdministradorParqueo
{
    partial class Login
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
            BtnRegistrar = new System.Windows.Forms.Button();
            TxtUsuario = new System.Windows.Forms.TextBox();
            TxtContrasena = new System.Windows.Forms.TextBox();
            LblUsuario = new System.Windows.Forms.Label();
            LblContrasena = new System.Windows.Forms.Label();
            BtnSalir = new System.Windows.Forms.Button();
            BtnIngresar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            BtnRegistrar.Location = new System.Drawing.Point(106, 211);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            BtnRegistrar.TabIndex = 3;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new System.Drawing.Point(74, 85);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.PlaceholderText = "Ingrese su usuario";
            TxtUsuario.Size = new System.Drawing.Size(252, 23);
            TxtUsuario.TabIndex = 1;
            // 
            // TxtContrasena
            // 
            TxtContrasena.Location = new System.Drawing.Point(74, 148);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.PlaceholderText = "Ingrese su contraseña";
            TxtContrasena.Size = new System.Drawing.Size(252, 23);
            TxtContrasena.TabIndex = 2;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Location = new System.Drawing.Point(74, 64);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new System.Drawing.Size(50, 15);
            LblUsuario.TabIndex = 30;
            LblUsuario.Text = "Usuario:";
            // 
            // LblContrasena
            // 
            LblContrasena.AutoSize = true;
            LblContrasena.Location = new System.Drawing.Point(74, 130);
            LblContrasena.Name = "LblContrasena";
            LblContrasena.Size = new System.Drawing.Size(70, 15);
            LblContrasena.TabIndex = 40;
            LblContrasena.Text = "Contraseña:";
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            BtnSalir.Location = new System.Drawing.Point(156, 254);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new System.Drawing.Size(75, 23);
            BtnSalir.TabIndex = 5;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new System.Drawing.Point(203, 211);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new System.Drawing.Size(75, 23);
            BtnIngresar.TabIndex = 4;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(397, 336);
            ControlBox = false;
            Controls.Add(BtnIngresar);
            Controls.Add(BtnSalir);
            Controls.Add(LblContrasena);
            Controls.Add(LblUsuario);
            Controls.Add(TxtContrasena);
            Controls.Add(TxtUsuario);
            Controls.Add(BtnRegistrar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnIngresar;
    }
}