using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Patinadores
{
    public partial class FormConsultaS : Form
    {
        string cadena;
        public FormConsultaS()
        {
            InitializeComponent();
        }

        private void btnAceptar(object sender, EventArgs e)
        {
            cadena = textConsulta.Text.Trim();
            if (cadena.Length == 0)
            {
                this.DialogResult = DialogResult.None;
            }

        }

        private void btnCancelar(object sender, EventArgs e)
        {

        }

        public string getCadena()
        {
            return cadena;
        }

        private void textConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (tecla == ' ' || tecla == '/' || tecla=='\\')
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
