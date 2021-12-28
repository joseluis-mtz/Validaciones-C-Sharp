using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Libreria

namespace Libreria_validacion
{
    public class Validar
    {
        // Método de validación de solo números
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            // Se verifica que se haya presionado una tecla con valor de digito
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            // Se verifica que se haya presionado una tecla con valor de caracter de control
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            // Si no se cumplen las condiciones anteriores se manda un mensaje de error.
            else
            {
                pE.Handled = true;
                MessageBox.Show("Error, Imposible digitar letras.\nEste campo solo admite números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("Error, Imposible digitar letras.\nEste campo solo admite letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SoloNumerosDecimales(KeyPressEventArgs pE)
        {
            if (Char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar.ToString().Equals("."))
            {
                pE.Handled = false;
            }
            else if (pE.KeyChar.ToString().Equals("-"))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("Error, Imposible digitar letras.\nEste campo solo admite números y punto decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void PresionarEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send(("{TAB}"));
            }
        }
    }
}
