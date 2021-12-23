﻿using System;
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
                MessageBox.Show("Error, Imposible digitar letras.\n Este campo solo admite números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}