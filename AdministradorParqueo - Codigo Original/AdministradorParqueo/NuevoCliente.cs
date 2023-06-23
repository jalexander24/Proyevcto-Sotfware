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
            if (Validaciones() == true)
            {
                return;
            }
            var nombre = TxtNombre.Text;
            var cedula = txtCedula.Text;
            var fechaSalida = "";
            var fechaLlegada = DtpFechaLlegada.Value.ToShortDateString();
            var horaLlegada = DtpHoraLlegada.Value.ToShortTimeString();
            var horaSalida = "";

            if (PorDefinirFecha.Checked == true)
            { fechaSalida = "Indefinido"; }
            else { fechaSalida = DtpFechaSalida.Value.ToShortDateString(); }

            if (PorDefinirHora.Checked == true)
            { horaSalida = "Indefinido"; }
            else { horaSalida = DtpHoraSalida.Value.ToShortTimeString(); }
            var Vehiculo = CmbVehiculo.SelectedItem.ToString();
            var estado = Estado.Checked.ToString();

            if (Accion == "nuevo")
            {
                try
                {


                    // Verificar si el cliente ya está registrado
                    if (ClienteYaRegistrado(cedula))
                    {
                        MessageBox.Show("El cliente ya está registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Escribir el contenido en el archivo
                    using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                    {
                        sw.WriteLine($"{nombre},{cedula},{nomlocal3},{Vehiculo},{fechaLlegada},{horaLlegada},{fechaSalida},{horaSalida},{estado}");
                    }

                    // Limpiar los campos de texto después de guardar
                    TxtNombre.Text = string.Empty;
                    txtCedula.Text = string.Empty;

                    MessageBox.Show("Cliente registrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el usuario: {ex.Message}");
                }
            }
            else
            {
                // Leer todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Crear una lista para almacenar las líneas actualizadas
                List<string> lineasActualizadas = new List<string>();

                // Recorrer cada línea del archivo
                foreach (string linea in lineas)
                {
                    // Dividir la línea en sus partes separadas por coma
                    string[] partes = linea.Split(',');

                    // Verificar si la cédula coincide con la variable Clientetraido
                    if (partes[1] == ClienteTraido)
                    {
                        // Actualizar los valores correspondientes
                        partes[0] = nombre;
                        partes[2] = nomlocal3;
                        partes[3] = Vehiculo;
                        partes[4] = fechaLlegada;
                        partes[5] = horaLlegada;
                        partes[6] = fechaSalida;
                        partes[7] = horaSalida;
                        partes[8] = estado;
                    }

                    // Agregar la línea actualizada a la lista
                    lineasActualizadas.Add(string.Join(",", partes));
                }

                // Sobrescribir el archivo con las líneas actualizadas
                File.WriteAllLines(rutaArchivo, lineasActualizadas);

                // Limpiar los campos de texto después de guardar
                TxtNombre.Text = string.Empty;
                txtCedula.Text = string.Empty;

                MessageBox.Show("Cliente actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            TablaClientes formularioPrincipal = Application.OpenForms.OfType<TablaClientes>().FirstOrDefault(); // Obtén el formulario principal si está abierto
            formularioPrincipal?.RecargarDatos();
            this.Dispose();
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

                // Comparar el usuario con el usuario registrado
                if (cedula.Equals(clienteRegistrado, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // cliente ya registrado
                }
            }

            return false; // cliente no registrado
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
                if (partes[6] == "Indefinido") { PorDefinirFecha.Checked = true; } else { DtpFechaSalida.Value = Convert.ToDateTime(partes[6]); }
                if (partes[7] == "Indefinido") { PorDefinirHora.Checked = true; } else { DtpHoraSalida.Value = Convert.ToDateTime(partes[7]); }
                if (partes[8] == "True") { Estado.Checked = true; } else { Estado.Checked = false; }
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
                MessageBox.Show("La hora de llegada no puede ser mayor a la hora de salida ", "Horas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
