namespace Patinadores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Infantil Menor");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Infantil Mayor");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Juvenil B");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Juvenil");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Libre");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Clasificados", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Micro");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Mini");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Infantil Menor");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Infantil Mayor");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Juvenil");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Open");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Transición / Deslizables", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Torneo", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode27});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolTorneo = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPatinadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPatinadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPatinadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLibre = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNombreModalidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFemenil = new System.Windows.Forms.RadioButton();
            this.rbtnVaronil = new System.Windows.Forms.RadioButton();
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelNombreTorneo = new System.Windows.Forms.Label();
            this.labelTorneo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Escuela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.btnToolTorneo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTorneoToolStripMenuItem,
            this.abrirToToolStripMenuItem,
            this.toolStripSeparator2,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator1,
            this.tToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoTorneoToolStripMenuItem
            // 
            this.nuevoTorneoToolStripMenuItem.Name = "nuevoTorneoToolStripMenuItem";
            this.nuevoTorneoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoTorneoToolStripMenuItem.Text = "Nuevo Torneo";
            this.nuevoTorneoToolStripMenuItem.Click += new System.EventHandler(this.btnNuevoTorneo);
            // 
            // abrirToToolStripMenuItem
            // 
            this.abrirToToolStripMenuItem.Name = "abrirToToolStripMenuItem";
            this.abrirToToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToToolStripMenuItem.Text = "Abrir Torneo";
            this.abrirToToolStripMenuItem.Click += new System.EventHandler(this.abrirToToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tToolStripMenuItem.Text = "Salir";
            this.tToolStripMenuItem.Click += new System.EventHandler(this.tToolStripMenuItem_Click);
            // 
            // btnToolTorneo
            // 
            this.btnToolTorneo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPatinadorToolStripMenuItem,
            this.modificarPatinadorToolStripMenuItem,
            this.eliminarPatinadorToolStripMenuItem});
            this.btnToolTorneo.Name = "btnToolTorneo";
            this.btnToolTorneo.Size = new System.Drawing.Size(57, 20);
            this.btnToolTorneo.Text = "Torneo";
            // 
            // agregarPatinadorToolStripMenuItem
            // 
            this.agregarPatinadorToolStripMenuItem.Name = "agregarPatinadorToolStripMenuItem";
            this.agregarPatinadorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarPatinadorToolStripMenuItem.Text = "Agregar Patinador";
            this.agregarPatinadorToolStripMenuItem.Click += new System.EventHandler(this.agregaPatinador);
            // 
            // modificarPatinadorToolStripMenuItem
            // 
            this.modificarPatinadorToolStripMenuItem.Name = "modificarPatinadorToolStripMenuItem";
            this.modificarPatinadorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarPatinadorToolStripMenuItem.Text = "Modificar Patinador";
            this.modificarPatinadorToolStripMenuItem.Click += new System.EventHandler(this.btnModificaPatinador);
            // 
            // eliminarPatinadorToolStripMenuItem
            // 
            this.eliminarPatinadorToolStripMenuItem.Name = "eliminarPatinadorToolStripMenuItem";
            this.eliminarPatinadorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarPatinadorToolStripMenuItem.Text = "Eliminar Patinador";
            this.eliminarPatinadorToolStripMenuItem.Click += new System.EventHandler(this.eliminaPatinador);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(32, 17);
            this.statusLabel.Text = "Listo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(949, 597);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 597);
            this.panel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "nodoCIMe";
            treeNode15.Text = "Infantil Menor";
            treeNode16.Name = "nodoCIMa";
            treeNode16.Text = "Infantil Mayor";
            treeNode17.Name = "nodoCJB";
            treeNode17.Text = "Juvenil B";
            treeNode18.Name = "nodoCJ";
            treeNode18.Text = "Juvenil";
            treeNode19.Name = "nodoCLibre";
            treeNode19.Text = "Libre";
            treeNode20.Name = "nodoClasificados";
            treeNode20.Text = "Clasificados";
            treeNode21.Name = "nodoTMi";
            treeNode21.Text = "Micro";
            treeNode22.Name = "nodoTMini";
            treeNode22.Text = "Mini";
            treeNode23.Name = "nodoTIMe";
            treeNode23.Text = "Infantil Menor";
            treeNode24.Name = "nodoTIMa";
            treeNode24.Text = "Infantil Mayor";
            treeNode25.Name = "nodoTJ";
            treeNode25.Text = "Juvenil";
            treeNode26.Name = "nodoTO";
            treeNode26.Text = "Open";
            treeNode27.Name = "nodoTransicion";
            treeNode27.Text = "Transición / Deslizables";
            treeNode28.Name = "nodoTorneo";
            treeNode28.Text = "Torneo";
            treeNode28.ToolTipText = "Torneo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(207, 597);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.seleccionaCategoria);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelNombreModalidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.labelNombreCategoria);
            this.panel1.Controls.Add(this.labelCategoria);
            this.panel1.Controls.Add(this.labelNombreTorneo);
            this.panel1.Controls.Add(this.labelTorneo);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 597);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLibre);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(350, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estilo";
            // 
            // rbLibre
            // 
            this.rbLibre.AutoSize = true;
            this.rbLibre.Location = new System.Drawing.Point(25, 28);
            this.rbLibre.Name = "rbLibre";
            this.rbLibre.Size = new System.Drawing.Size(70, 28);
            this.rbLibre.TabIndex = 1;
            this.rbLibre.TabStop = true;
            this.rbLibre.Text = "Libre";
            this.rbLibre.UseVisualStyleBackColor = true;
            this.rbLibre.CheckedChanged += new System.EventHandler(this.estiloSeleccionado);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 28);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Combinado";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.estiloSeleccionado);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNombreModalidad
            // 
            this.labelNombreModalidad.AutoSize = true;
            this.labelNombreModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreModalidad.Location = new System.Drawing.Point(160, 70);
            this.labelNombreModalidad.Name = "labelNombreModalidad";
            this.labelNombreModalidad.Size = new System.Drawing.Size(109, 24);
            this.labelNombreModalidad.TabIndex = 7;
            this.labelNombreModalidad.Text = "Clasificados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modalidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFemenil);
            this.groupBox1.Controls.Add(this.rbtnVaronil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(510, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rama de la Categoria";
            // 
            // rbtnFemenil
            // 
            this.rbtnFemenil.AutoSize = true;
            this.rbtnFemenil.Location = new System.Drawing.Point(25, 28);
            this.rbtnFemenil.Name = "rbtnFemenil";
            this.rbtnFemenil.Size = new System.Drawing.Size(97, 28);
            this.rbtnFemenil.TabIndex = 1;
            this.rbtnFemenil.TabStop = true;
            this.rbtnFemenil.Text = "Femenil";
            this.rbtnFemenil.UseVisualStyleBackColor = true;
            this.rbtnFemenil.CheckedChanged += new System.EventHandler(this.ramaSeleccionada);
            // 
            // rbtnVaronil
            // 
            this.rbtnVaronil.AutoSize = true;
            this.rbtnVaronil.Location = new System.Drawing.Point(25, 62);
            this.rbtnVaronil.Name = "rbtnVaronil";
            this.rbtnVaronil.Size = new System.Drawing.Size(87, 28);
            this.rbtnVaronil.TabIndex = 0;
            this.rbtnVaronil.TabStop = true;
            this.rbtnVaronil.Text = "Varonil";
            this.rbtnVaronil.UseVisualStyleBackColor = true;
            this.rbtnVaronil.CheckedChanged += new System.EventHandler(this.ramaSeleccionada);
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.AutoSize = true;
            this.labelNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCategoria.Location = new System.Drawing.Point(160, 118);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(122, 24);
            this.labelNombreCategoria.TabIndex = 4;
            this.labelNombreCategoria.Text = "Infantil Menor";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(14, 118);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(95, 24);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelNombreTorneo
            // 
            this.labelNombreTorneo.AutoSize = true;
            this.labelNombreTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreTorneo.Location = new System.Drawing.Point(264, 12);
            this.labelNombreTorneo.Name = "labelNombreTorneo";
            this.labelNombreTorneo.Size = new System.Drawing.Size(108, 31);
            this.labelNombreTorneo.TabIndex = 2;
            this.labelNombreTorneo.Text = "Torneo:";
            // 
            // labelTorneo
            // 
            this.labelTorneo.AutoSize = true;
            this.labelTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTorneo.Location = new System.Drawing.Point(150, 12);
            this.labelTorneo.Name = "labelTorneo";
            this.labelTorneo.Size = new System.Drawing.Size(108, 31);
            this.labelTorneo.TabIndex = 1;
            this.labelTorneo.Text = "Torneo:";
            this.labelTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellidos,
            this.Estado,
            this.Escuela,
            this.Edad});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(20, 177);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(706, 377);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "Apellidos";
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            // 
            // Escuela
            // 
            this.Escuela.Text = "Escuela";
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Imprime Lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 643);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.resizeListView);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnToolTorneo;
        private System.Windows.Forms.ToolStripMenuItem agregarPatinadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPatinadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPatinadorToolStripMenuItem;
        private System.Windows.Forms.Label labelTorneo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelNombreTorneo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFemenil;
        private System.Windows.Forms.RadioButton rbtnVaronil;
        private System.Windows.Forms.Label labelNombreModalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellidos;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Escuela;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLibre;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
    }
}

