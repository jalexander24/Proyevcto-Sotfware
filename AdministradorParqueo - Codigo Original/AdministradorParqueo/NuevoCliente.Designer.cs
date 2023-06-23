
namespace AdministradorParqueo
{
    partial class NuevoCliente
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
            LblNombre = new System.Windows.Forms.Label();
            TxtNombre = new System.Windows.Forms.TextBox();
            txtCedula = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CmbVehiculo = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            Estado = new System.Windows.Forms.CheckBox();
            DtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            DtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            PorDefinirHora = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            DtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            PorDefinirFecha = new System.Windows.Forms.CheckBox();
            BtnSalir = new System.Windows.Forms.Button();
            BtnRegistrar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new System.Drawing.Point(23, 44);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new System.Drawing.Size(54, 15);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new System.Drawing.Point(83, 41);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(186, 23);
            TxtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new System.Drawing.Point(349, 41);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(186, 23);
            txtCedula.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(296, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Cedula:";
            // 
            // CmbVehiculo
            // 
            CmbVehiculo.FormattingEnabled = true;
            CmbVehiculo.Location = new System.Drawing.Point(110, 183);
            CmbVehiculo.Name = "CmbVehiculo";
            CmbVehiculo.Size = new System.Drawing.Size(121, 23);
            CmbVehiculo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo Vehiculo:";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            Estado.Location = new System.Drawing.Point(301, 185);
            Estado.Name = "Estado";
            Estado.Size = new System.Drawing.Size(63, 19);
            Estado.TabIndex = 11;
            Estado.Text = "Activo:";
            Estado.UseVisualStyleBackColor = true;
            // 
            // DtpHoraLlegada
            // 
            DtpHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            DtpHoraLlegada.Location = new System.Drawing.Point(114, 116);
            DtpHoraLlegada.Name = "DtpHoraLlegada";
            DtpHoraLlegada.Size = new System.Drawing.Size(82, 23);
            DtpHoraLlegada.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 122);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 15);
            label3.TabIndex = 8;
            label3.Text = "Hora Llegada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(296, 122);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Hora Salida:";
            // 
            // DtpHoraSalida
            // 
            DtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            DtpHoraSalida.Location = new System.Drawing.Point(377, 116);
            DtpHoraSalida.Name = "DtpHoraSalida";
            DtpHoraSalida.Size = new System.Drawing.Size(82, 23);
            DtpHoraSalida.TabIndex = 8;
            // 
            // PorDefinirHora
            // 
            PorDefinirHora.AutoSize = true;
            PorDefinirHora.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            PorDefinirHora.Location = new System.Drawing.Point(488, 121);
            PorDefinirHora.Name = "PorDefinirHora";
            PorDefinirHora.Size = new System.Drawing.Size(85, 19);
            PorDefinirHora.TabIndex = 9;
            PorDefinirHora.Text = "Por Definir:";
            PorDefinirHora.UseVisualStyleBackColor = true;
            PorDefinirHora.CheckedChanged += PorDefinirHora_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 85);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 15);
            label5.TabIndex = 13;
            label5.Text = "Fecha Llegada:";
            // 
            // DtpFechaLlegada
            // 
            DtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DtpFechaLlegada.Location = new System.Drawing.Point(114, 79);
            DtpFechaLlegada.Name = "DtpFechaLlegada";
            DtpFechaLlegada.Size = new System.Drawing.Size(82, 23);
            DtpFechaLlegada.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(296, 85);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 15;
            label6.Text = "Fecha Salida:";
            // 
            // DtpFechaSalida
            // 
            DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DtpFechaSalida.Location = new System.Drawing.Point(377, 79);
            DtpFechaSalida.Name = "DtpFechaSalida";
            DtpFechaSalida.Size = new System.Drawing.Size(82, 23);
            DtpFechaSalida.TabIndex = 5;
            // 
            // PorDefinirFecha
            // 
            PorDefinirFecha.AutoSize = true;
            PorDefinirFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            PorDefinirFecha.Location = new System.Drawing.Point(488, 81);
            PorDefinirFecha.Name = "PorDefinirFecha";
            PorDefinirFecha.Size = new System.Drawing.Size(85, 19);
            PorDefinirFecha.TabIndex = 6;
            PorDefinirFecha.Text = "Por Definir:";
            PorDefinirFecha.UseVisualStyleBackColor = true;
            PorDefinirFecha.CheckedChanged += PorDefinirFecha_CheckedChanged;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            BtnSalir.Location = new System.Drawing.Point(498, 267);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new System.Drawing.Size(75, 23);
            BtnSalir.TabIndex = 18;
            BtnSalir.Text = "Cancelar";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            BtnRegistrar.Location = new System.Drawing.Point(399, 267);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            BtnRegistrar.TabIndex = 17;
            BtnRegistrar.Text = "Guardar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnGuardar_Click;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(606, 324);
            ControlBox = false;
            Controls.Add(BtnSalir);
            Controls.Add(BtnRegistrar);
            Controls.Add(PorDefinirFecha);
            Controls.Add(label6);
            Controls.Add(DtpFechaSalida);
            Controls.Add(label5);
            Controls.Add(DtpFechaLlegada);
            Controls.Add(PorDefinirHora);
            Controls.Add(label4);
            Controls.Add(DtpHoraSalida);
            Controls.Add(label3);
            Controls.Add(DtpHoraLlegada);
            Controls.Add(Estado);
            Controls.Add(label2);
            Controls.Add(CmbVehiculo);
            Controls.Add(txtCedula);
            Controls.Add(label1);
            Controls.Add(TxtNombre);
            Controls.Add(LblNombre);
            Name = "NuevoCliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Estado;
        private System.Windows.Forms.DateTimePicker DtpHoraLlegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpHoraSalida;
        private System.Windows.Forms.CheckBox PorDefinirHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpFechaLlegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFechaSalida;
        private System.Windows.Forms.CheckBox PorDefinirFecha;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}