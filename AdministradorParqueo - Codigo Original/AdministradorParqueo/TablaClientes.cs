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

namespace AdministradorParqueo
{
    public partial class TablaClientes : Form
    {
        public string nomlocal2;
        public string rutaArchivo;
        public string clienteSeleccionado;

        public TablaClientes()
        {
            InitializeComponent();

            // Obtener la ruta absoluta del archivo "usuarios.txt" en la misma carpeta del proyecto
            string directorioProyecto = Path.GetDirectoryName(Application.ExecutablePath);
            rutaArchivo = Path.Combine(directorioProyecto, "clientes.txt");
        }

        public void CargarClientes()
        {
            // Leer todas las líneas del archivo
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Crear una lista para almacenar los datos seleccionados
            List<ClienteModel> clientes = new List<ClienteModel>();

            // Recorrer cada línea del archivo
            foreach (string linea in lineas)
            {
                // Dividir la línea en sus partes separadas por coma
                string[] partes = linea.Split(',');

                // Verificar si el valor de nomlocal2 coincide con el valor en la línea
                if (partes[2] == nomlocal2)
                {
                    // se agregan los datos correspondientes 
                    ClienteModel cliente = new ClienteModel();
                    cliente.nombre = partes[0];
                    cliente.cedula = partes[1];
                    cliente.local = partes[2];
                    cliente.tipoVehiculo = partes[3];
                    cliente.fechaLlegad = partes[4];
                    cliente.horaLlegada = partes[5];
                    cliente.fechaSalida = partes[6];
                    cliente.horaSalida = partes[7];
                    cliente.estado = partes[8];
                    clientes.Add(cliente);
                }
            }

            if (clientes.Count() > 0)
            {
                foreach (var i in clientes)
                {
                    var estadoCliente = "";
                    if (i.estado == "True") { estadoCliente = "Activo"; } else { estadoCliente = "Inactivo"; }
                    DgvClientes.Rows.Add(i.nombre, i.cedula, i.tipoVehiculo, i.fechaLlegad, i.horaLlegada, i.fechaSalida, i.horaSalida, estadoCliente);
                }
            }

            // Aquí puedes hacer lo que necesites con la lista de clientes seleccionados,
            // como llenar una tabla o realizar alguna operación con los datos.
        }

        public void RecargarDatos()
        {
            DgvClientes.Rows.Clear(); // Limpia los datos existentes en el DataGridView

            // Vuelve a cargar los clientes
            CargarClientes();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevo = new NuevoCliente();
            nuevo.SetNomLocal(nomlocal2);
            nuevo.Show();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            NuevoCliente editar = new NuevoCliente();
            editar.SetNomLocal(nomlocal2);
            editar.SetClienteTraido(clienteSeleccionado);
            editar.Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formnulario
        }

        public void SetNomLocal(string nomlocal)
        {
            nomlocal2 = nomlocal;
            LblTitulo.Text = nomlocal2;
            CargarClientes();
        }



        private void TablaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Verificar si no hay más formularios abiertos
            {
                Application.Exit(); // Cerrar la aplicación si no hay formularios abiertos
            }
            else
            {
                Login loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault(); // Obtener el formulario Login si está abierto
                if (loginForm != null)
                {
                    loginForm.Show(); // Mostrar el formulario Login nuevamente
                }
            }
        }

        private void DgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count > 0)
            {
                // Obtiene la cédula de la fila seleccionada
                string cedulaSeleccionada = DgvClientes.SelectedRows[0].Cells["Cedula"].Value.ToString();
                clienteSeleccionado = cedulaSeleccionada;

                // Activa el botón de editar
                BtnEditar.Enabled = true;
            }
            else
            {
                // No hay filas seleccionadas, desactiva el botón de editar
                BtnEditar.Enabled = false;
            }
        }

    }
}
