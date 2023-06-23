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
    public partial class Registrar : Form
    {
        private string rutaArchivo;

        public Registrar()
        {
            InitializeComponent();

            // Obtener la ruta absoluta del archivo "usuarios.txt" en la misma carpeta del proyecto
            string directorioProyecto = Path.GetDirectoryName(Application.ExecutablePath);
            rutaArchivo = Path.Combine(directorioProyecto, "usuarios.txt");
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validaciones() == true)
            {
                return;
            }
            try
            {
                string usuario = TxtUsuario.Text;
                string contrasena = TxtContrasena.Text;
                string local = TxtNomLocal.Text;

                // Verificar si el usuario ya está registrado
                if (UsuarioYaRegistrado(usuario))
                {
                    MessageBox.Show("El usuario ya está registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el nombre del local ya está registrado
                if (NombreLocalYaRegistrado(local))
                {
                    MessageBox.Show("El nombre del local ya está registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Escribir el contenido en el archivo
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine($"{usuario},{contrasena},{local}");
                }

                // Limpiar los campos de texto después de guardar
                TxtUsuario.Text = string.Empty;
                TxtContrasena.Text = string.Empty;
                TxtNomLocal.Text = string.Empty;

                MessageBox.Show("Usuario registrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}");
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

            if (string.IsNullOrWhiteSpace(TxtNomLocal.Text))
            {
                MessageBox.Show("Ingrese un nombre de local", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }


        private bool UsuarioYaRegistrado(string usuario)
        {
            // Leer el archivo de usuarios
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Recorrer las líneas y verificar si el usuario ya está registrado
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                string usuarioRegistrado = datos[0].Trim();

                // Comparar el usuario con el usuario registrado
                if (usuario.Equals(usuarioRegistrado, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Usuario ya registrado
                }
            }

            return false; // Usuario no registrado
        }


        private bool NombreLocalYaRegistrado(string local)
        {
            // Leer el archivo de usuarios
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Recorrer las líneas y verificar si el nombre del local ya está registrado
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                string nombreLocalRegistrado = datos[2].Trim();

                // Comparar el nombre del local con el nombre local registrado
                if (local.Equals(nombreLocalRegistrado, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Nombre del local ya registrado
                }
            }

            return false; // Nombre del local no registrado
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
