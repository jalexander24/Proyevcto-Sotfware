using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdministradorParqueo
{
    public partial class NuevoCliente : Form
    {
        public string nomlocal3;
        public string rutaArchivo;
        public string ClienteTraido;
        public string Accion = "nuevo";

        public NuevoCliente()
        {
            InitializeComponent();
            // Dar valores al combobox
            CmbVehiculo.Items.AddRange(new string[] { "Automóvil", "Moto", "Camión" });
            // Establecer el primer valor como seleccionado por defecto
            CmbVehiculo.SelectedIndex = 0;

            // Obtener la ruta absoluta del archivo "usuarios.txt" en la misma carpeta del proyecto
            string directorioProyecto = Path.GetDirectoryName(Application.ExecutablePath);
            rutaArchivo = Path.Combine(directorioProyecto, "clientes.txt");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = TxtNombre.Text;
            var cedula = txtCedula.Text;
            var fechaSalida = "";
            var fechaLlegada = DtpFechaLlegada.Value.ToShortDateString();
            var horaLlegada = DtpHoraLlegada.Value.ToShortTimeString();
            var horaSalida = "";

            if (PorDefinirFecha.Checked)
            {
                fechaSalida = "Indefinido";
            }
            else
            {
                fechaSalida = DtpFechaSalida.Value.ToShortDateString();
            }

            if (PorDefinirHora.Checked)
            {
                horaSalida = "Indefinido";
            }
            else
            {
                horaSalida = DtpHoraSalida.Value.ToShortTimeString();
            }

            var vehiculo = CmbVehiculo.SelectedItem.ToString();
            var estado = Estado.Checked.ToString();

            if (Accion == "nuevo")
            {
                try
                {
                    if (ClienteYaRegistrado(cedula))
                    {
                        MessageBox.Show("El cliente ya está registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (StreamWriter sw = new StreamWriter(rutaArchivo, append: true))
                    {
                        sw.WriteLine($"{nombre},{cedula},{nomlocal3},{vehiculo},
        {fechaLlegada},{horaLlegada},{fechaSalida},
        {horaSalida},{estado}");
                    }

                    TxtNombre.Text = string.Empty;
                    txtCedula.Text = string.Empty;

                    MessageBox.Show("Cliente registrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el cliente: {ex.Message}");
                }
            }
            else
            {
                try
                {
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    List<string> lineasActualizadas = new List<string>();

                    foreach (string linea in lineas)
                    {
                        string[] partes = linea.Split(',');

                        if (partes[1] == ClienteTraido)
                        {
                            partes[0] = nombre;
                            partes[2] = nomlocal3;
                            partes[3] = vehiculo;
                            partes[4] = fechaLlegada;
                            partes[5] = horaLlegada;
                            partes[6] = fechaSalida;
                            partes[7] = horaSalida;
                            partes[8] = estado;
                        }

                        lineasActualizadas.Add(string.Join(",", partes));
                    }

                    File.WriteAllLines(rutaArchivo, lineasActualizadas);

                    TxtNombre.Text = string.Empty;
                    txtCedula.Text = string.Empty;

                    MessageBox.Show("Cliente actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el cliente: {ex.Message}");
                }
            }

            TablaClientes formularioPrincipal = Application.OpenForms.OfType<TablaClientes>().FirstOrDefault();
            formularioPrincipal?.RecargarDatos();
            Dispose();
        }

        private bool ClienteYaRegistrado(string cedula)
        {
            // Leer el archivo de clientes
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Recorrer las líneas y verificar si el cliente ya está registrado
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                string clienteRegistrado = datos[1].Trim();

                // Comparar la cédula con la cédula del cliente registrado
                if (cedula.Equals(clienteRegistrado, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Cliente ya registrado
                }
            }

            return false; // Cliente no registrado
        }

        public void SetNomLocal(string nomlocal)
        {
            nomlocal3 = nomlocal;
        }

        public void SetClienteTraido(string cedula)
        {
            ClienteTraido = cedula;
            Accion = "editar";
            SetearValores();
        }

        public void SetearValores()
        {
            // Leer todas las líneas del archivo
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Buscar el registro que coincide con Clientetraido
            string lineaEncontrada = lineas.FirstOrDefault(linea => linea.Contains(ClienteTraido));

            if (lineaEncontrada != null)
            {
                // Dividir la línea en sus partes separadas por coma
                string[] partes = lineaEncontrada.Split(',');

                // Obtener los valores correspondientes y asignarlos a los controles del formulario
                TxtNombre.Text = partes[0];
                txtCedula.Text = partes[1];
                CmbVehiculo.SelectedItem = partes[3];
                DtpFechaLlegada.Value = Convert.ToDateTime(partes[4]);
                DtpHoraLlegada.Value = Convert.ToDateTime(partes[5]);
                PorDefinirFecha.Checked = partes[6] == "Indefinido";
                DtpFechaSalida.Value = PorDefinirFecha.Checked ? DateTime.Today : Convert.ToDateTime(partes[6]);
                PorDefinirHora.Checked = partes[7] == "Indefinido";
                DtpHoraSalida.Value = PorDefinirHora.Checked ? DateTime.Now : Convert.ToDateTime(partes[7]);
                Estado.Checked = partes[8] == "True";
            }
        }

        private bool Validaciones()
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de cliente", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Ingrese una cedula de cliente", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            DateTime fechaLlegada = DtpFechaLlegada.Value.Date;
            DateTime fechaSalida = DtpFechaSalida.Value.Date;

            if (fechaLlegada > fechaSalida)
            {
                MessageBox.Show("La fecha de llegada no puede ser mayor a la fecha de salida", "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            TimeSpan horaLlegada = DtpHoraLlegada.Value.TimeOfDay;
            TimeSpan horaSalida = DtpHoraSalida.Value.TimeOfDay;

            if (fechaLlegada == fechaSalida && horaLlegada > horaSalida)
            {
                MessageBox.Show("La hora de llegada no puede ser mayor a la hora de salida", "Horas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PorDefinirFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (PorDefinirFecha.Checked == true) { DtpFechaSalida.Enabled = false; } else { DtpFechaSalida.Enabled = true; }
        }

        private void PorDefinirHora_CheckedChanged(object sender, EventArgs e)
        {
            if (PorDefinirHora.Checked == true) { DtpHoraSalida.Enabled = false; } else { DtpHoraSalida.Enabled = true; }

        }
    }

}
