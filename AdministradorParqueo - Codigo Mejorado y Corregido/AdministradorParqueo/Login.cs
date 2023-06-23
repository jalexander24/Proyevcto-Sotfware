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
    public partial class Login : Form
    {
        private string rutaArchivo;
        private string nomlocal;

        public Login()
        {
            InitializeComponent();
            // Obtener la ruta absoluta del archivo "usuarios.txt" en la misma carpeta del proyecto
            string directorioProyecto = Path.GetDirectoryName(Application.ExecutablePath);
            rutaArchivo = Path.Combine(directorioProyecto, "usuarios.txt");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Registrar formularioRegistrar = new Registrar();

            // Mostrar el formulario nuevo
            formularioRegistrar.Show();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                return;
            }

            string usuario = TxtUsuario.Text;
            string contrasena = TxtContrasena.Text;

            // Leer el contenido del archivo y buscar el usuario y contraseña
            bool inicioSesionExitoso = false;
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 3 && partes[0] == usuario && partes[1] == contrasena)
                    {
                        nomlocal = partes[2]; //Obtiene el nombre del local
                        inicioSesionExitoso = true;
                        break;
                    }
                }
            }

            // Mostrar el mensaje de inicio de sesión
            if (inicioSesionExitoso)
            {
                IniciarSesion(nomlocal);
                this.Hide();
                // Limpiar los campos de texto después de iniciar sesión
                TxtUsuario.Text = string.Empty;
                TxtContrasena.Text = string.Empty;
            }
            else
            {
                nomlocal = "";
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool Validaciones()
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (string.IsNullOrWhiteSpace(TxtContrasena.Text))
            {
                MessageBox.Show("Ingrese una contraseña", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        public void IniciarSesion(string local)
        {
            TablaClientes TablaClientesWinform = new TablaClientes();
            TablaClientesWinform.SetNomLocal(local);
            TablaClientesWinform.Show();
        }
    }
}

