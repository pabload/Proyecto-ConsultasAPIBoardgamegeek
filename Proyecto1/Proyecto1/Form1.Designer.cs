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
            this.panelDatosJuegoElegido = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDatosJuegoElegido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenJuego)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.textBoxNombreUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(332, 32);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.BtnBuscarUsuario_Click);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(191, 32);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(132, 22);
            this.textBoxNombreUsuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del usuarrio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.labelInformacionInferior);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 32);
            this.panel2.TabIndex = 3;
            // 
            // labelInformacionInferior
            // 
            this.labelInformacionInferior.AutoSize = true;
            this.labelInformacionInferior.Location = new System.Drawing.Point(216, 7);
            this.labelInformacionInferior.Name = "labelInformacionInferior";
            this.labelInformacionInferior.Size = new System.Drawing.Size(16, 17);
            this.labelInformacionInferior.TabIndex = 1;
            this.labelInformacionInferior.Text = "..";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 32);
            this.progressBar1.TabIndex = 0;
            // 
            // treeViewAutores
            // 
            this.treeViewAutores.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAutores.ImageIndex = 0;
            this.treeViewAutores.ImageList = this.imageListTreeview;
            this.treeViewAutores.Location = new System.Drawing.Point(0, 86);
            this.treeViewAutores.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewAutores.Name = "treeViewAutores";
            this.treeViewAutores.SelectedImageIndex = 0;
            this.treeViewAutores.Size = new System.Drawing.Size(209, 436);
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
            this.listViewContenidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewContenidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContenidos.LargeImageList = this.imageListContendioListView;
            this.listViewContenidos.Location = new System.Drawing.Point(0, 0);
            this.listViewContenidos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewContenidos.MultiSelect = false;
            this.listViewContenidos.Name = "listViewContenidos";
            this.listViewContenidos.Size = new System.Drawing.Size(986, 436);
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
            // panelDatosJuegoElegido
            // 
            this.panelDatosJuegoElegido.Controls.Add(this.dataGridView1);
            this.panelDatosJuegoElegido.Controls.Add(this.richTextBoxDescripcionJuego);
            this.panelDatosJuegoElegido.Controls.Add(this.panel4);
            this.panelDatosJuegoElegido.Controls.Add(this.pictureBoxImagenJuego);
            this.panelDatosJuegoElegido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosJuegoElegido.Location = new System.Drawing.Point(0, 0);
            this.panelDatosJuegoElegido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDatosJuegoElegido.Name = "panelDatosJuegoElegido";
            this.panelDatosJuegoElegido.Size = new System.Drawing.Size(986, 436);
            this.panelDatosJuegoElegido.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(548, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(403, 156);
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
            this.richTextBoxDescripcionJuego.Location = new System.Drawing.Point(267, 240);
            this.richTextBoxDescripcionJuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescripcionJuego.Name = "richTextBoxDescripcionJuego";
            this.richTextBoxDescripcionJuego.Size = new System.Drawing.Size(261, 157);
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
            this.panel4.Location = new System.Drawing.Point(267, 27);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 207);
            this.panel4.TabIndex = 10;
            // 
            // labelNumeroTotalPartidas
            // 
            this.labelNumeroTotalPartidas.AutoSize = true;
            this.labelNumeroTotalPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTotalPartidas.Location = new System.Drawing.Point(460, 74);
            this.labelNumeroTotalPartidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroTotalPartidas.Name = "labelNumeroTotalPartidas";
            this.labelNumeroTotalPartidas.Size = new System.Drawing.Size(145, 52);
            this.labelNumeroTotalPartidas.TabIndex = 10;
            this.labelNumeroTotalPartidas.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero total de partidas";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del juego:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelNombreJuego
            // 
            this.labelNombreJuego.AutoSize = true;
            this.labelNombreJuego.Location = new System.Drawing.Point(132, 30);
            this.labelNombreJuego.Name = "labelNombreJuego";
            this.labelNombreJuego.Size = new System.Drawing.Size(68, 17);
            this.labelNombreJuego.TabIndex = 2;
            this.labelNombreJuego.Text = "(Nombre)";
            this.labelNombreJuego.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBoxIlustradoresJuego
            // 
            this.textBoxIlustradoresJuego.Location = new System.Drawing.Point(157, 121);
            this.textBoxIlustradoresJuego.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIlustradoresJuego.Multiline = true;
            this.textBoxIlustradoresJuego.Name = "textBoxIlustradoresJuego";
            this.textBoxIlustradoresJuego.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIlustradoresJuego.Size = new System.Drawing.Size(247, 24);
            this.textBoxIlustradoresJuego.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autores del juego:";
            // 
            // textBoxAutoresJuego
            // 
            this.textBoxAutoresJuego.Location = new System.Drawing.Point(157, 74);
            this.textBoxAutoresJuego.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAutoresJuego.Multiline = true;
            this.textBoxAutoresJuego.Name = "textBoxAutoresJuego";
            this.textBoxAutoresJuego.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAutoresJuego.Size = new System.Drawing.Size(247, 24);
            this.textBoxAutoresJuego.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilustradores del juego:";
            // 
            // pictureBoxImagenJuego
            // 
            this.pictureBoxImagenJuego.Location = new System.Drawing.Point(23, 27);
            this.pictureBoxImagenJuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagenJuego.Name = "pictureBoxImagenJuego";
            this.pictureBoxImagenJuego.Size = new System.Drawing.Size(228, 369);
            this.pictureBoxImagenJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenJuego.TabIndex = 0;
            this.pictureBoxImagenJuego.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewContenidos);
            this.panel3.Controls.Add(this.panelDatosJuegoElegido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(209, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 436);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1195, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.treeViewAutores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDatosJuegoElegido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenJuego)).EndInit();
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
        private System.Windows.Forms.Panel panelDatosJuegoElegido;
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
    }
}

