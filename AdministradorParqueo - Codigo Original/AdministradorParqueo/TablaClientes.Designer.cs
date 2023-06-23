
namespace AdministradorParqueo
{
    partial class TablaClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            DgvClientes = new System.Windows.Forms.DataGridView();
            Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaLLegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LblTitulo = new System.Windows.Forms.Label();
            BtnNuevo = new System.Windows.Forms.Button();
            BtnEditar = new System.Windows.Forms.Button();
            BtnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // DgvClientes
            // 
            DgvClientes.AllowUserToAddRows = false;
            DgvClientes.AllowUserToDeleteRows = false;
            DgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Cliente, Cedula, TipoVehiculo, FechaLLegada, HoraLlegada, FechaSalida, HoraSalida, Estado });
            DgvClientes.GridColor = System.Drawing.SystemColors.Window;
            DgvClientes.Location = new System.Drawing.Point(12, 134);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.RowTemplate.Height = 25;
            DgvClientes.Size = new System.Drawing.Size(776, 353);
            DgvClientes.TabIndex = 0;
            DgvClientes.SelectionChanged += DgvClientes_SelectionChanged;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            // 
            // TipoVehiculo
            // 
            TipoVehiculo.HeaderText = "TipoVehiculo";
            TipoVehiculo.Name = "TipoVehiculo";
            // 
            // FechaLLegada
            // 
            FechaLLegada.HeaderText = "Fecha LLegada";
            FechaLLegada.Name = "FechaLLegada";
            FechaLLegada.ReadOnly = true;
            // 
            // HoraLlegada
            // 
            HoraLlegada.HeaderText = "Hora Llegada";
            HoraLlegada.Name = "HoraLlegada";
            HoraLlegada.ReadOnly = true;
            // 
            // FechaSalida
            // 
            FechaSalida.HeaderText = "Fecha Salida";
            FechaSalida.Name = "FechaSalida";
            FechaSalida.ReadOnly = true;
            // 
            // HoraSalida
            // 
            HoraSalida.HeaderText = "Hora Salida";
            HoraSalida.Name = "HoraSalida";
            HoraSalida.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblTitulo.Location = new System.Drawing.Point(12, 18);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new System.Drawing.Size(335, 37);
            LblTitulo.TabIndex = 1;
            LblTitulo.Text = "TITULO DE PARQUEADERO";
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new System.Drawing.Point(623, 103);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new System.Drawing.Size(75, 23);
            BtnNuevo.TabIndex = 2;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Enabled = false;
            BtnEditar.Location = new System.Drawing.Point(713, 103);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new System.Drawing.Size(75, 23);
            BtnEditar.TabIndex = 3;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Location = new System.Drawing.Point(12, 520);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new System.Drawing.Size(116, 23);
            BtnCerrarSesion.TabIndex = 4;
            BtnCerrarSesion.Text = "Cerrar Sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // TablaClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 553);
            ControlBox = false;
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNuevo);
            Controls.Add(LblTitulo);
            Controls.Add(DgvClientes);
            Name = "TablaClientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TablaClientes";
            FormClosing += TablaClientes_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLLegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}