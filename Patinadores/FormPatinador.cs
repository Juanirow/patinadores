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
    partial class FormPatinador : Form
    {
        Torneo torneo;
        bool modificacion;
        Patinador p;
        string ant_categoria, ant_estilo;
        bool ant_ramaFemenil;

        public FormPatinador()
        {
            InitializeComponent();
            comboEvento.SelectedIndex = 0;
        }

        public FormPatinador(ref Torneo t, Patinador patinador,string categora,string estilo,bool ramaFemenil)
        {
            InitializeComponent();
            modificacion = true;
            p = patinador;
            cargaPatinador(categora, estilo, ramaFemenil);
            btnAceptaryC.Visible = false;
            ant_categoria=categora;
            ant_estilo=estilo;
            ant_ramaFemenil=ramaFemenil;
            torneo = t;
            
        }

        public FormPatinador(ref Torneo t)
        {
            InitializeComponent();
            comboEvento.SelectedIndex = 0;
            torneo = t;
            modificacion = false;
        }

        private void cargaPatinador(string categora,string estilo,bool ramaFemenil)
        {
            textApellidos.Text = p.Apellidos;
            textNombre.Text = p.Nombre;
            textEdo.Text = p.Estado;
            textEscuela.Text = p.Escuela;
            numericUpDown1.Value = p.Edad;
            radioBtnF.Checked = ramaFemenil;
            int otraCat = 0;
            if (estilo == "Clasificados")
            {
                comboEvento.SelectedIndex = 0;
                switch (categora)
                {
                    case "Infantil Menor": otraCat = 0; break;
                    case "Infantil Mayor": otraCat = 1; break;
                    case "Juvenil": otraCat = 2; break;
                    case "Juvenil B": otraCat = 3; break;
                    case "Libre": otraCat = 4; break;
                }
            }
            else
            {
                comboEvento.SelectedIndex = 1;
                switch (categora)
                {
                    case "Micro": otraCat = 0; break;
                    case "Mini ": otraCat = 1; break;
                    case "Infantil Menor": otraCat = 2; break;
                    case "Infantil Mayor": otraCat = 3; break;
                    case "Juvenil": otraCat =4; break;
                    case "Open": otraCat = 5; break;
                }
            }
            comboBox1.SelectedIndex = otraCat;
            
            
        }

        private void eventoSeleccionado(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (comboEvento.SelectedIndex == 0)
            {
                comboBox1.Items.Add("Infantil Menor");
                comboBox1.Items.Add("Infantil Mayor");
                comboBox1.Items.Add("Juvenil");
                comboBox1.Items.Add("Juvenil B");
                comboBox1.Items.Add("Libre");
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Items.Add("Micro");
                comboBox1.Items.Add("Mini");
                comboBox1.Items.Add("Infantil Menor");
                comboBox1.Items.Add("Infantil Mayor");
                comboBox1.Items.Add("Juvenil");
                comboBox1.Items.Add("Open");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void aceptar(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                if (cbCombinado.Checked || cbLibre.Checked)
                {
                    string nom, ape, edo, esc;
                    nom = textNombre.Text.Trim();
                    ape = textApellidos.Text.Trim();
                    edo = textEdo.Text.Trim();
                    esc = textEscuela.Text.Trim();
                    bool estiloClasificados = true;
                    if (comboEvento.Text != "Clasificados")
                        estiloClasificados = false;
                    torneo.InsertaPatinador(nom, ape, esc, edo, comboBox1.Text, (int)numericUpDown1.Value, estiloClasificados, radioBtnF.Checked, cbLibre.Checked, cbCombinado.Checked);
                    if (modificacion)
                    {
                        bool bandClasificados = true;
                        if (ant_estilo != "Clasificados")
                            bandClasificados = false;
                        if(p.EstiloLibre)
                            torneo.eliminaPatinador(ant_ramaFemenil, ant_categoria, p, bandClasificados,true);
                        if(p.EstiloCombinado)
                            torneo.eliminaPatinador(ant_ramaFemenil, ant_categoria, p, bandClasificados, false);
                    }
                    limpiaCampos();
                    Serializar.serializaTorneo(torneo);
                }
                else
                {
                    MessageBox.Show("El competidor debe de participar en un estilo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("No Puede haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private bool validaCampos()
        {
            string nombre = textNombre.Text.Trim();
            if (nombre.Length == 0)
                return false;
            string apellidos = textApellidos.Text.Trim();
            if (nombre.Length == 0)
                return false;
            string estado = textEdo.Text.Trim();
            if (estado.Length == 0)
                return false;
            string escuela = textEscuela.Text.Trim();
            if (escuela.Length == 0)
                return false;
            return true;
        }

        private void limpiaCampos()
        {
            textApellidos.Text = "";
            textNombre.Text = "";
            textEdo.Text = "";
            textEscuela.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (modificacion)
            {

            }
        }
    }
}
