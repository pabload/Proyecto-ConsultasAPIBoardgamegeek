using System;

namespace Proyecto1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelInformacionInferior = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.treeViewAutores = new System.Windows.Forms.TreeView();
            this.imageListTreeview = new System.Windows.Forms.ImageList(this.components);
            this.imageListContendioListView = new System.Windows.Forms.ImageList(this.components);
            this.listViewContenidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDatosInformacionEspecifica = new System.Windows.Forms.Panel();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelNombreAutorMasJuegos = new System.Windows.Forms.Label();
            this.pictureBoxAutorMas = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTotalJuegosUsuario = new System.Windows.Forms.Label();
            this.pictureBoxTotalJuegos = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelJuegoMasJugado = new System.Windows.Forms.Label();
            this.pictureBoxJuegoMasjugado = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelNombreAdMasGanador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelNombreAdMasPerdedor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuarioResumen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroJugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidasGanadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidasPerdidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxDescripcionJuego = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNumeroTotalPartidas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNombreJuego = new System.Windows.Forms.Label();
            this.textBoxIlustradoresJuego = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAutoresJuego = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxImagenJuego = new System.Windows.Forms.PictureBox();
            this.panelDatosAdversario = new System.Windows.Forms.Panel();
            this.labelInfoAdversario = new System.Windows.Forms.Label();
            this.dataGridViewAdversarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDatosInformacionEspecifica.SuspendLayout();
            this.panelResumen.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutorMas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalJuegos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuegoMasjugado)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenJuego)).BeginInit();
            this.panelDatosAdversario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdversarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.textBoxNombreUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(487, 7);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(165, 41);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscarUsuario_Click);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(269, 7);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreUsuario.Multiline = true;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(209, 41);
            this.textBoxNombreUsuario.TabIndex = 6;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.TextBoxNombreUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del usuario:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.labelInformacionInferior);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 32);
            this.panel2.TabIndex = 3;
            // 
            // labelInformacionInferior
            // 
            this.labelInformacionInferior.AutoSize = true;
            this.labelInformacionInferior.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacionInferior.ForeColor = System.Drawing.Color.White;
            this.labelInformacionInferior.Location = new System.Drawing.Point(215, 2);
            this.labelInformacionInferior.Name = "labelInformacionInferior";
            this.labelInformacionInferior.Size = new System.Drawing.Size(27, 29);
            this.labelInformacionInferior.TabIndex = 1;
            this.labelInformacionInferior.Text = "..";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 32);
            this.progressBar1.TabIndex = 0;
            // 
            // treeViewAutores
            // 
            this.treeViewAutores.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAutores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAutores.ImageIndex = 0;
            this.treeViewAutores.ImageList = this.imageListTreeview;
            this.treeViewAutores.Location = new System.Drawing.Point(0, 60);
            this.treeViewAutores.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewAutores.Name = "treeViewAutores";
            this.treeViewAutores.SelectedImageIndex = 0;
            this.treeViewAutores.Size = new System.Drawing.Size(209, 462);
            this.treeViewAutores.StateImageList = this.imageListTreeview;
            this.treeViewAutores.TabIndex = 4;
            this.treeViewAutores.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewAutores_BeforeCollapse);
            this.treeViewAutores.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewAutores_BeforeExpand);
            this.treeViewAutores.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAutores_AfterSelect);
            // 
            // imageListTreeview
            // 
            this.imageListTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeview.ImageStream")));
            this.imageListTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeview.Images.SetKeyName(0, "IconoAuto.png");
            this.imageListTreeview.Images.SetKeyName(1, "juegos-de-mesa.png");
            // 
            // imageListContendioListView
            // 
            this.imageListContendioListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListContendioListView.ImageStream")));
            this.imageListContendioListView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListContendioListView.Images.SetKeyName(0, "IconoAuto.png");
            this.imageListContendioListView.Images.SetKeyName(1, "juegos-de-mesa.png");
            // 
            // listViewContenidos
            // 
            this.listViewContenidos.BackColor = System.Drawing.Color.White;
            this.listViewContenidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewContenidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContenidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewContenidos.LargeImageList = this.imageListContendioListView;
            this.listViewContenidos.Location = new System.Drawing.Point(0, 0);
            this.listViewContenidos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewContenidos.MultiSelect = false;
            this.listViewContenidos.Name = "listViewContenidos";
            this.listViewContenidos.Size = new System.Drawing.Size(995, 462);
            this.listViewContenidos.SmallImageList = this.imageListContendioListView;
            this.listViewContenidos.TabIndex = 5;
            this.listViewContenidos.UseCompatibleStateImageBehavior = false;
            this.listViewContenidos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewContenidos_ItemSelectionChanged);
            this.listViewContenidos.SelectedIndexChanged += new System.EventHandler(this.ListViewContenidos_SelectedIndexChanged);
            this.listViewContenidos.Click += new System.EventHandler(this.ListViewContenidos_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Autor";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ilustrador";
            // 
            // panelDatosInformacionEspecifica
            // 
            this.panelDatosInformacionEspecifica.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDatosInformacionEspecifica.Controls.Add(this.panelResumen);
            this.panelDatosInformacionEspecifica.Controls.Add(this.dataGridView1);
            this.panelDatosInformacionEspecifica.Controls.Add(this.richTextBoxDescripcionJuego);
            this.panelDatosInformacionEspecifica.Controls.Add(this.panel4);
            this.panelDatosInformacionEspecifica.Controls.Add(this.pictureBoxImagenJuego);
            this.panelDatosInformacionEspecifica.Controls.Add(this.panelDatosAdversario);
            this.panelDatosInformacionEspecifica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosInformacionEspecifica.Location = new System.Drawing.Point(0, 0);
            this.panelDatosInformacionEspecifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDatosInformacionEspecifica.Name = "panelDatosInformacionEspecifica";
            this.panelDatosInformacionEspecifica.Size = new System.Drawing.Size(995, 462);
            this.panelDatosInformacionEspecifica.TabIndex = 6;
            // 
            // panelResumen
            // 
            this.panelResumen.Controls.Add(this.tabControl1);
            this.panelResumen.Controls.Add(this.labelNombreUsuarioResumen);
            this.panelResumen.Location = new System.Drawing.Point(0, 0);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(995, 495);
            this.panelResumen.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(132, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 347);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelNombreAutorMasJuegos);
            this.tabPage1.Controls.Add(this.pictureBoxAutorMas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autor con mas juegos ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelNombreAutorMasJuegos
            // 
            this.labelNombreAutorMasJuegos.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAutorMasJuegos.Location = new System.Drawing.Point(163, 158);
            this.labelNombreAutorMasJuegos.Name = "labelNombreAutorMasJuegos";
            this.labelNombreAutorMasJuegos.Size = new System.Drawing.Size(444, 138);
            this.labelNombreAutorMasJuegos.TabIndex = 1;
            this.labelNombreAutorMasJuegos.Text = "label7";
            this.labelNombreAutorMasJuegos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAutorMas
            // 
            this.pictureBoxAutorMas.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAutorMas.Image")));
            this.pictureBoxAutorMas.Location = new System.Drawing.Point(319, 15);
            this.pictureBoxAutorMas.Name = "pictureBoxAutorMas";
            this.pictureBoxAutorMas.Size = new System.Drawing.Size(134, 136);
            this.pictureBoxAutorMas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAutorMas.TabIndex = 0;
            this.pictureBoxAutorMas.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTotalJuegosUsuario);
            this.tabPage2.Controls.Add(this.pictureBoxTotalJuegos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Total de juegos en coleccion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTotalJuegosUsuario
            // 
            this.labelTotalJuegosUsuario.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalJuegosUsuario.Location = new System.Drawing.Point(175, 165);
            this.labelTotalJuegosUsuario.Name = "labelTotalJuegosUsuario";
            this.labelTotalJuegosUsuario.Size = new System.Drawing.Size(444, 132);
            this.labelTotalJuegosUsuario.TabIndex = 2;
            this.labelTotalJuegosUsuario.Text = "label7";
            this.labelTotalJuegosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxTotalJuegos
            // 
            this.pictureBoxTotalJuegos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTotalJuegos.Image")));
            this.pictureBoxTotalJuegos.Location = new System.Drawing.Point(319, 17);
            this.pictureBoxTotalJuegos.Name = "pictureBoxTotalJuegos";
            this.pictureBoxTotalJuegos.Size = new System.Drawing.Size(134, 136);
            this.pictureBoxTotalJuegos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTotalJuegos.TabIndex = 1;
            this.pictureBoxTotalJuegos.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelJuegoMasJugado);
            this.tabPage3.Controls.Add(this.pictureBoxJuegoMasjugado);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Juego mas jugado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelJuegoMasJugado
            // 
            this.labelJuegoMasJugado.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJuegoMasJugado.Location = new System.Drawing.Point(174, 154);
            this.labelJuegoMasJugado.Name = "labelJuegoMasJugado";
            this.labelJuegoMasJugado.Size = new System.Drawing.Size(444, 136);
            this.labelJuegoMasJugado.TabIndex = 3;
            this.labelJuegoMasJugado.Text = "label7";
            this.labelJuegoMasJugado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJuegoMasJugado.Click += new System.EventHandler(this.LabelJuegoMasJugado_Click);
            // 
            // pictureBoxJuegoMasjugado
            // 
            this.pictureBoxJuegoMasjugado.Location = new System.Drawing.Point(319, 15);
            this.pictureBoxJuegoMasjugado.Name = "pictureBoxJuegoMasjugado";
            this.pictureBoxJuegoMasjugado.Size = new System.Drawing.Size(134, 136);
            this.pictureBoxJuegoMasjugado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJuegoMasjugado.TabIndex = 2;
            this.pictureBoxJuegoMasjugado.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelNombreAdMasGanador);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 318);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Adversario mas ganador";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelNombreAdMasGanador
            // 
            this.labelNombreAdMasGanador.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAdMasGanador.Location = new System.Drawing.Point(162, 153);
            this.labelNombreAdMasGanador.Name = "labelNombreAdMasGanador";
            this.labelNombreAdMasGanador.Size = new System.Drawing.Size(444, 149);
            this.labelNombreAdMasGanador.TabIndex = 4;
            this.labelNombreAdMasGanador.Text = "label7";
            this.labelNombreAdMasGanador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.labelNombreAdMasPerdedor);
            this.tabPage5.Controls.Add(this.pictureBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(780, 318);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Adversario mas perdedor";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelNombreAdMasPerdedor
            // 
            this.labelNombreAdMasPerdedor.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAdMasPerdedor.Location = new System.Drawing.Point(170, 154);
            this.labelNombreAdMasPerdedor.Name = "labelNombreAdMasPerdedor";
            this.labelNombreAdMasPerdedor.Size = new System.Drawing.Size(444, 140);
            this.labelNombreAdMasPerdedor.TabIndex = 5;
            this.labelNombreAdMasPerdedor.Text = "label7";
            this.labelNombreAdMasPerdedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(319, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // labelNombreUsuarioResumen
            // 
            this.labelNombreUsuarioResumen.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuarioResumen.Location = new System.Drawing.Point(130, 25);
            this.labelNombreUsuarioResumen.Name = "labelNombreUsuarioResumen";
            this.labelNombreUsuarioResumen.Size = new System.Drawing.Size(788, 57);
            this.labelNombreUsuarioResumen.TabIndex = 1;
            this.labelNombreUsuarioResumen.Text = "(nombre Usuario)";
            this.labelNombreUsuarioResumen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombreUsuarioResumen.Click += new System.EventHandler(this.LabelNombreUsuarioResumen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroJugadores,
            this.partidasGanadas,
            this.partidasPerdidas});
            this.dataGridView1.Location = new System.Drawing.Point(548, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(438, 202);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // NumeroJugadores
            // 
            this.NumeroJugadores.HeaderText = "Numero de jugadores";
            this.NumeroJugadores.MinimumWidth = 6;
            this.NumeroJugadores.Name = "NumeroJugadores";
            this.NumeroJugadores.ReadOnly = true;
            // 
            // partidasGanadas
            // 
            this.partidasGanadas.HeaderText = "Partidas ganadas";
            this.partidasGanadas.MinimumWidth = 6;
            this.partidasGanadas.Name = "partidasGanadas";
            this.partidasGanadas.ReadOnly = true;
            // 
            // partidasPerdidas
            // 
            this.partidasPerdidas.HeaderText = "Partidas perdidas";
            this.partidasPerdidas.MinimumWidth = 6;
            this.partidasPerdidas.Name = "partidasPerdidas";
            this.partidasPerdidas.ReadOnly = true;
            // 
            // richTextBoxDescripcionJuego
            // 
            this.richTextBoxDescripcionJuego.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescripcionJuego.Location = new System.Drawing.Point(244, 233);
            this.richTextBoxDescripcionJuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescripcionJuego.Name = "richTextBoxDescripcionJuego";
            this.richTextBoxDescripcionJuego.Size = new System.Drawing.Size(304, 202);
            this.richTextBoxDescripcionJuego.TabIndex = 9;
            this.richTextBoxDescripcionJuego.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelNumeroTotalPartidas);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.labelNombreJuego);
            this.panel4.Controls.Add(this.textBoxIlustradoresJuego);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxAutoresJuego);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(244, 27);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(742, 210);
            this.panel4.TabIndex = 10;
            // 
            // labelNumeroTotalPartidas
            // 
            this.labelNumeroTotalPartidas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTotalPartidas.Location = new System.Drawing.Point(533, 49);
            this.labelNumeroTotalPartidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroTotalPartidas.Name = "labelNumeroTotalPartidas";
            this.labelNumeroTotalPartidas.Size = new System.Drawing.Size(132, 75);
            this.labelNumeroTotalPartidas.TabIndex = 10;
            this.labelNumeroTotalPartidas.Text = "label6";
            this.labelNumeroTotalPartidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelNumeroTotalPartidas.Click += new System.EventHandler(this.LabelNumeroTotalPartidas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = " Total de partidas";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del juego:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelNombreJuego
            // 
            this.labelNombreJuego.AutoSize = true;
            this.labelNombreJuego.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreJuego.Location = new System.Drawing.Point(205, 31);
            this.labelNombreJuego.Name = "labelNombreJuego";
            this.labelNombreJuego.Size = new System.Drawing.Size(79, 24);
            this.labelNombreJuego.TabIndex = 2;
            this.labelNombreJuego.Text = "(Nombre)";
            this.labelNombreJuego.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBoxIlustradoresJuego
            // 
            this.textBoxIlustradoresJuego.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIlustradoresJuego.Location = new System.Drawing.Point(204, 119);
            this.textBoxIlustradoresJuego.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIlustradoresJuego.Multiline = true;
            this.textBoxIlustradoresJuego.Name = "textBoxIlustradoresJuego";
            this.textBoxIlustradoresJuego.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIlustradoresJuego.Size = new System.Drawing.Size(305, 29);
            this.textBoxIlustradoresJuego.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autores del juego:";
            // 
            // textBoxAutoresJuego
            // 
            this.textBoxAutoresJuego.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutoresJuego.Location = new System.Drawing.Point(203, 73);
            this.textBoxAutoresJuego.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAutoresJuego.Multiline = true;
            this.textBoxAutoresJuego.Name = "textBoxAutoresJuego";
            this.textBoxAutoresJuego.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAutoresJuego.Size = new System.Drawing.Size(307, 29);
            this.textBoxAutoresJuego.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilustradores del juego:";
            // 
            // pictureBoxImagenJuego
            // 
            this.pictureBoxImagenJuego.Location = new System.Drawing.Point(11, 27);
            this.pictureBoxImagenJuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagenJuego.Name = "pictureBoxImagenJuego";
            this.pictureBoxImagenJuego.Size = new System.Drawing.Size(236, 408);
            this.pictureBoxImagenJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenJuego.TabIndex = 0;
            this.pictureBoxImagenJuego.TabStop = false;
            // 
            // panelDatosAdversario
            // 
            this.panelDatosAdversario.Controls.Add(this.labelInfoAdversario);
            this.panelDatosAdversario.Controls.Add(this.dataGridViewAdversarios);
            this.panelDatosAdversario.Location = new System.Drawing.Point(11, 26);
            this.panelDatosAdversario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDatosAdversario.Name = "panelDatosAdversario";
            this.panelDatosAdversario.Size = new System.Drawing.Size(975, 409);
            this.panelDatosAdversario.TabIndex = 12;
            // 
            // labelInfoAdversario
            // 
            this.labelInfoAdversario.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoAdversario.Location = new System.Drawing.Point(3, 14);
            this.labelInfoAdversario.Name = "labelInfoAdversario";
            this.labelInfoAdversario.Size = new System.Drawing.Size(923, 33);
            this.labelInfoAdversario.TabIndex = 0;
            this.labelInfoAdversario.Text = "label6";
            this.labelInfoAdversario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridViewAdversarios
            // 
            this.dataGridViewAdversarios.AllowUserToAddRows = false;
            this.dataGridViewAdversarios.AllowUserToDeleteRows = false;
            this.dataGridViewAdversarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdversarios.Location = new System.Drawing.Point(3, 50);
            this.dataGridViewAdversarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAdversarios.Name = "dataGridViewAdversarios";
            this.dataGridViewAdversarios.ReadOnly = true;
            this.dataGridViewAdversarios.RowHeadersWidth = 51;
            this.dataGridViewAdversarios.RowTemplate.Height = 24;
            this.dataGridViewAdversarios.Size = new System.Drawing.Size(972, 359);
            this.dataGridViewAdversarios.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelDatosInformacionEspecifica);
            this.panel3.Controls.Add(this.listViewContenidos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(209, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 462);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1204, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.treeViewAutores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consultas BoardGameGeek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDatosInformacionEspecifica.ResumeLayout(false);
            this.panelResumen.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutorMas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalJuegos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuegoMasjugado)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenJuego)).EndInit();
            this.panelDatosAdversario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdversarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeViewAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.ImageList imageListTreeview;
        private System.Windows.Forms.ImageList imageListContendioListView;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelInformacionInferior;
        private System.Windows.Forms.ListView listViewContenidos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panelDatosInformacionEspecifica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidasGanadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidasPerdidas;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcionJuego;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelNumeroTotalPartidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNombreJuego;
        private System.Windows.Forms.TextBox textBoxIlustradoresJuego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAutoresJuego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxImagenJuego;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDatosAdversario;
        private System.Windows.Forms.DataGridView dataGridViewAdversarios;
        private System.Windows.Forms.Label labelInfoAdversario;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Label labelNombreUsuarioResumen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelNombreAutorMasJuegos;
        private System.Windows.Forms.PictureBox pictureBoxAutorMas;
        private System.Windows.Forms.PictureBox pictureBoxTotalJuegos;
        private System.Windows.Forms.Label labelTotalJuegosUsuario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelJuegoMasJugado;
        private System.Windows.Forms.PictureBox pictureBoxJuegoMasjugado;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelNombreAdMasGanador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label labelNombreAdMasPerdedor;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

