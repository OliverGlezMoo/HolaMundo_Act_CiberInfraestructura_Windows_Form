using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {
            Contraseña.PasswordChar = '*';
        }

        private void Confirmar_TextChanged(object sender, EventArgs e)
        {
            Confirmar.PasswordChar = '*';
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            if (ValidarContrasena(Contraseña.Text))
            {   // Si la contraseña es válida, comparamos los textos de ambos
                // textbox para asegurarnos de que coincidan.
                if (Contraseña.Text == Confirmar.Text)
                {// Si las contraseñas coinciden, mostramos un mensaje de éxito al usuario.
                    MessageBox.Show("La contraseña ha sido validada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {// Si las contraseñas no coinciden, mostramos un mensaje de advertencia al usuario.
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }// Si la contraseña no cumple con los requisitos, mostramos un mensaje de error al usuario.
            else
            {
                MessageBox.Show("La contraseña no cumple con los requisitos:\n- Al menos una mayúscula\n- Al menos una minúscula\n- Un número\n- Al menos un símbolo especial\n- Mínimo 8 caracteres",
                                "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarContrasena(string password)
        {
            // Regex: 
            // (?=.*[a-z]) : Al menos una minúscula
            // (?=.*[A-Z]) : Al menos una mayúscula
            // (?=.*\d)    : Al menos un número
            // (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
