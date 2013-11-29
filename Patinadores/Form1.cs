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
    public partial class Form1 : Form
    {
        Torneo t;
        string path;
        string modalidad, categoria;
        Categoria impAct;
        DateTime date;
        bool impActLibre;
        string impModalidad;
        public Form1()
        {
            InitializeComponent();
            t = null;
            path = "";
            btnToolTorneo.Enabled = false;
            rbtnFemenil.Checked = true;
            rbLibre.Checked = true;
            listView1.Enabled = false;
            modalidad = "";
            impModalidad = "";
            categoria = "";
            impAct = null;
            impActLibre = false;
        }

        private void seleccionaCategoria(object sender, TreeViewEventArgs e)
        {
            TreeView t = (TreeView)sender;
            TreeNode nodo = t.SelectedNode;
            if (nodo.Parent != null)
            {
                string cadena = nodo.Parent.Text;
                if (cadena == "Clasificados" || cadena == "Transición / Deslizables")
                {
                    labelNombreModalidad.Text = cadena;
                    modalidad = cadena;
                    categoria = nodo.Text;
                    labelNombreCategoria.Text = nodo.Text;
                    statusLabel.Text = "Cargando Tabla " + nodo.Text;
                    cargaDatosTabla();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Serializar.crearDirectorioInicial();
            cargaPosicionListView();
        }

        private void cargaPosicionListView()
        {
            int dis = panel1.Height - listView1.Location.Y;
            listView1.Height = dis-20;
            int x = panel1.Width - listView1.Location.X;
            listView1.Width = x - 20;
            int ancho=listView1.Width-80;

            int tam = ancho / 4;
            for (int i = 0; i < 5; i++)
            {
                if(i==4)
                    listView1.Columns[i].Width = 80;
                else
                    listView1.Columns[i].Width = tam;
            }
        }

        private void btnNuevoTorneo(object sender, EventArgs e)
        {
            FormConsultaS fcs = new FormConsultaS();
            string cadena;
            string ruta;
            statusLabel.Text = "Creando Torneo";
            if (fcs.ShowDialog() == DialogResult.OK)
            {
                cadena = fcs.getCadena();
                ruta = @"/" + cadena;
                if (!Serializar.existeDirectorio(ruta))
                {
                    creaTorneo(cadena, ruta);
                    statusLabel.Text = "Torneo "+ cadena+" creado";
                    listView1.Enabled = true;
                }
                else
                    if (MessageBox.Show("El Torneo ya existe desea SobreEscribirlo", "Pelation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Serializar.eliminaDirectorio(ruta);
                        creaTorneo(cadena, ruta);
                        statusLabel.Text = "Torneo " + cadena + " creado";
                        listView1.Enabled = true;
                    }
            }
            cargaDatosTabla();
        }

        private void creaTorneo(string cadena,string ruta)
        {
            t = new Torneo(cadena);
            Serializar.crearDirectorio(ruta);
            labelNombreTorneo.Text = cadena;
            labelNombreCategoria.Text = "Infantil Menor";
            treeView1.Nodes[0].Text += " " + cadena;
            splitContainer1.Enabled = true;
            btnToolTorneo.Enabled = true;
            path = Serializar.ruta + @"/" + cadena ;
            Serializar.serializaTorneo(t);
        }

        private void resizeListView(object sender, EventArgs e)
        {
            cargaPosicionListView();
        }

        private void cargaDatosTabla()
        {
            bool ramaF = rbtnFemenil.Checked;
            if (modalidad != "" && categoria != "")
            {
                bool clasificados=true;
                if(modalidad!="Clasificados")
                    clasificados=false;
                if (t != null)
                {
                    List<Patinador> p;
                    p = t.getPatinadores(clasificados, categoria, ramaF,rbLibre.Checked);
                    listView1.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                    {
                        listView1.Items.Add(p[i].Nombre);
                        listView1.Items[i].SubItems.Add(p[i].Apellidos);
                        listView1.Items[i].SubItems.Add(p[i].Estado);
                        listView1.Items[i].SubItems.Add(p[i].Escuela);
                        listView1.Items[i].SubItems.Add(p[i].Edad.ToString());
                    }
                }
            }
        }

        private void agregaPatinador(object sender, EventArgs e)
        {
            FormPatinador f = new FormPatinador(ref t);
            f.ShowDialog();
            cargaDatosTabla();
        }

        private void btnModificaPatinador(object sender, EventArgs e)
        {
            bool ramaF = rbtnFemenil.Checked;
            int pos = -1;
            if (listView1.SelectedItems.Count > 0)
                pos = listView1.SelectedIndices[0];

            if (modalidad != "" && categoria != "" && pos != -1)
            {
                bool mC=true;
                 if(modalidad!="Clasificados")
                     mC=false;
                Patinador p=t.getPatinadorAt(ramaF,categoria,pos,mC,rbLibre.Checked);
                FormPatinador fp = new FormPatinador(ref t, p, categoria, modalidad, ramaF);
                fp.ShowDialog();
                cargaDatosTabla();
            }
            else
                MessageBox.Show("Selecciona un Patinador para eliminar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void eliminaPatinador(object sender, EventArgs e)
        {
             bool ramaF = rbtnFemenil.Checked;
             int pos=-1;
            if (listView1.SelectedItems.Count > 0)
                pos= listView1.SelectedIndices[0];

             if (modalidad != "" && categoria != "" && pos != -1)
             {
                 bool mC=true;
                 if(modalidad!="Clasificados")
                     mC=false;
                 Patinador p = t.getPatinadorAt(ramaF, categoria, pos, mC, rbLibre.Checked);
                 string cadena = "Seguro que desea Eliminar al Patinador " + p.Nombre + " " + p.Apellidos;
                 DialogResult d;
                 d=MessageBox.Show(cadena, "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (d == DialogResult.Yes)
                 {
                     t.eliminaPatinador(ramaF, categoria, pos, mC, rbLibre.Checked);
                     Serializar.serializaTorneo(t);
                 }
                 cargaDatosTabla();
             }
             else
                 MessageBox.Show("Selecciona un Patinador para eliminar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void ramaSeleccionada(object sender, EventArgs e)
        {
            cargaDatosTabla();
        }

        private void abrirToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombre;
            string path;
            openFileDialog1.Filter="Archivos Patinaje|*.pt";
            openFileDialog1.InitialDirectory=@"C:\Patinaje";
            openFileDialog1.Title = "Seleccion un archivo de patinaje";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombre = openFileDialog1.FileName;
                t = Serializar.desealizaTorneo(nombre);
                if (t != null)
                {
                    string cadena;
                    cadena = t.getNombreTorneo();
                    labelNombreTorneo.Text = cadena;
                    labelNombreCategoria.Text = "Infantil Menor";
                    treeView1.Nodes[0].Text += " " + cadena;
                    splitContainer1.Enabled = true;
                    btnToolTorneo.Enabled = true;
                    path = Serializar.ruta + @"/" + cadena;
                    listView1.Enabled = true;
                    listView1.Items.Clear();
                    treeView1.Nodes[0].Collapse();
                    cargaDatosTabla();
                }
                else
                    MessageBox.Show("No se pudo Abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            bool ramaF = rbtnFemenil.Checked;
            if (modalidad != "" && categoria != "")
            {
                bool clasificados = true;
                if (modalidad != "Clasificados")
                    clasificados = false;
                if (t != null)
                {
                    d = MessageBox.Show("Seguro que desea Generar la lista de Patinadores en modalidad: "+modalidad+" y estilo: "+clasificados, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        t.generaRandom(ramaF, categoria, clasificados, rbLibre.Checked);
                        Serializar.serializaTorneo(t);
                        cargaDatosTabla();
                    }
                }
            }     
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(t!=null)
                Serializar.serializaTorneo(t);
            this.Close();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    date = DateTime.Now;
                    bool libre = false;
                    do
                    {
                        bool femenil = false;
                        do
                        {
                            for (short j = 0; j < 2; j++)
                            {
                                for (short i = 0; i < t.getNumCategoriasAtEstilo(femenil, j); i++)
                                {
                                    impAct = t.getCategoriasAtEstilo(i, femenil, j);
                                    if (impAct.getNumPatinadores(libre) > 0)
                                    {
                                        printDocument1.DocumentName = "Imprimiendo Lista " + impAct.Rama + "," + impAct.Nombre;
                                        printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                                        printDocument1.Print();
                                    }
                                }
                            }
                            femenil = !femenil;
                        } while (femenil);
                        libre = !libre;
                    } while (libre);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (t != null)
            {
                Imprime imp = new Imprime(e,t.getNombreTorneo(),impAct,date,impActLibre,impModalidad);
                imp.ImprimeTorneo();
            }
        }

        private void estiloSeleccionado(object sender, EventArgs e)
        {
            cargaDatosTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d;
            bool ramaF = rbtnFemenil.Checked;
            if (modalidad != "" && categoria != "")
            {
                bool clasificados = true;
                if (modalidad != "Clasificados")
                    clasificados = false;
                if (t != null)
                {
                    d = MessageBox.Show("Seguro que desea Imprimir la lista de Patinadores en modalidad: " + modalidad + " y categoria: " + categoria, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        int estilo = 1;
                        impActLibre = rbLibre.Checked;
                        impModalidad = modalidad;
                        if (clasificados)
                            estilo = 0;   
                        int pos=t.getPosCategoria(categoria,clasificados);
                        impAct=t.getCategoriasAtEstilo(pos,ramaF,estilo);
                        if (impAct.getNumPatinadores(impActLibre) > 0)
                        {
                            if (printDialog1.ShowDialog() == DialogResult.OK)
                            {
                                date = DateTime.Now;
                                printDocument1.DocumentName = "Imprimiendo Lista " + impAct.Rama + "," + impAct.Nombre;
                                printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                                printDocument1.Print();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede Imprimir una Lista vacia ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }     
        }
    }
}
