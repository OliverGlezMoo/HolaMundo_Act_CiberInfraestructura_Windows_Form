using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
// Importamos los sistemas necesarios para la ejecución

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializacion de los componentes
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 1 para que el texto se mantenga incluso si el foco está en el textbox
            SendMessage(Contraseña.Handle, EM_SETCUEBANNER, 1, "Escribe tu Contraseña");
            SendMessage(Confirmar.Handle, EM_SETCUEBANNER, 1, "Confirma tu Contraseña");
        }
        // Función para imitar el funcionamiento de la propiedad de PlaceHolder, con el fin de que sea más limpio y no
        // afecte a futuras actualizaciones al momento de emplear bases de datos.

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {
            Contraseña.PasswordChar = '*';
        }
        // Creación de una sentencia para volver cada caracter de las contraseñas en *
        private void Confirmar_TextChanged(object sender, EventArgs e)
        {
            Confirmar.PasswordChar = '*';
        }
        // Creación de la funcion click del boton
        private void Validar_Click(object sender, EventArgs e)
        {
            if (ValidarContrasena(Contraseña.Text))
            {   // Mandamos a llamar a la funcion de validar contraseña, en cuyo caso la contraseña cumpla con los requisitos
                // Procedemos a compararla con el textbox de confirmar contraseña.
                if (Contraseña.Text == Confirmar.Text)
                {
                    MessageBox.Show("La contraseña ha sido validada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }// Si las contraseñas coinciden, mostramos un mensaje de éxito al usuario.
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }// Si las contraseñas no coinciden, mostramos un mensaje de advertencia al usuario.
            }
            else
            {
                MessageBox.Show("La contraseña no cumple con los requisitos:\n- Al menos una mayúscula\n- Al menos una minúscula\n- Al menos un número\n- Al menos un símbolo especial\n- Mínimo 8 caracteres",
                                "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }// Si la contraseña no cumple con los requisitos, mostramos un mensaje de error al usuario.
        }
        // Función de validación de la contraseña con las siguientes especificaciones;
        private bool ValidarContrasena(string password)
        {
            // (?=.*[a-z]) : Al menos una minúscula
            // (?=.*[A-Z]) : Al menos una mayúscula
            // (?=.*\d)    : Al menos un número
            // (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
