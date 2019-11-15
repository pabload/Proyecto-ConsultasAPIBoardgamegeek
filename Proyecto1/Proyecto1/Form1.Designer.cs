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
            this.treeViewAutores = new System.Windows.Forms.TreeView();
            this.imageListAutores = new System.Windows.Forms.ImageList(this.components);
            this.listViewContenidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListContendioListView = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDatosJuegoElegido = new System.Windows.Forms.Panel();
            this.pictureBoxImagenJuego = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNombreJuego = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAutorJuego = new System.Windows.Forms.Label();
            this.labelIlustradorJuego = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDatosJuegoElegido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenJuego)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(332, 32);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 32);
            this.panel2.TabIndex = 3;
            // 
            // treeViewAutores
            // 
            this.treeViewAutores.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAutores.ImageIndex = 0;
            this.treeViewAutores.ImageList = this.imageListAutores;
            this.treeViewAutores.Location = new System.Drawing.Point(0, 86);
            this.treeViewAutores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewAutores.Name = "treeViewAutores";
            this.treeViewAutores.SelectedImageIndex = 0;
            this.treeViewAutores.Size = new System.Drawing.Size(209, 436);
            this.treeViewAutores.StateImageList = this.imageListAutores;
            this.treeViewAutores.TabIndex = 4;
            this.treeViewAutores.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAutores_AfterSelect);
            // 
            // imageListAutores
            // 
            this.imageListAutores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAutores.ImageStream")));
            this.imageListAutores.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAutores.Images.SetKeyName(0, "IconoAuto.png");
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
            this.listViewContenidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewContenidos.Name = "listViewContenidos";
            this.listViewContenidos.Size = new System.Drawing.Size(858, 436);
            this.listViewContenidos.SmallImageList = this.imageListContendioListView;
            this.listViewContenidos.TabIndex = 5;
            this.listViewContenidos.UseCompatibleStateImageBehavior = false;
            this.listViewContenidos.SelectedIndexChanged += new System.EventHandler(this.ListViewContenidos_SelectedIndexChanged);
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
            // imageListContendioListView
            // 
            this.imageListContendioListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListContendioListView.ImageStream")));
            this.imageListContendioListView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListContendioListView.Images.SetKeyName(0, "IconoAuto.png");
            this.imageListContendioListView.Images.SetKeyName(1, "IconoAuto.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewContenidos);
            this.panel3.Controls.Add(this.panelDatosJuegoElegido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(209, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 436);
            this.panel3.TabIndex = 6;
            // 
            // panelDatosJuegoElegido
            // 
            this.panelDatosJuegoElegido.Controls.Add(this.labelIlustradorJuego);
            this.panelDatosJuegoElegido.Controls.Add(this.labelAutorJuego);
            this.panelDatosJuegoElegido.Controls.Add(this.label5);
            this.panelDatosJuegoElegido.Controls.Add(this.label4);
            this.panelDatosJuegoElegido.Controls.Add(this.labelNombreJuego);
            this.panelDatosJuegoElegido.Controls.Add(this.label2);
            this.panelDatosJuegoElegido.Controls.Add(this.pictureBoxImagenJuego);
            this.panelDatosJuegoElegido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosJuegoElegido.Location = new System.Drawing.Point(0, 0);
            this.panelDatosJuegoElegido.Name = "panelDatosJuegoElegido";
            this.panelDatosJuegoElegido.Size = new System.Drawing.Size(858, 436);
            this.panelDatosJuegoElegido.TabIndex = 6;
            // 
            // pictureBoxImagenJuego
            // 
            this.pictureBoxImagenJuego.Location = new System.Drawing.Point(66, 48);
            this.pictureBoxImagenJuego.Name = "pictureBoxImagenJuego";
            this.pictureBoxImagenJuego.Size = new System.Drawing.Size(251, 350);
            this.pictureBoxImagenJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenJuego.TabIndex = 0;
            this.pictureBoxImagenJuego.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del juego:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelNombreJuego
            // 
            this.labelNombreJuego.AutoSize = true;
            this.labelNombreJuego.Location = new System.Drawing.Point(470, 63);
            this.labelNombreJuego.Name = "labelNombreJuego";
            this.labelNombreJuego.Size = new System.Drawing.Size(68, 17);
            this.labelNombreJuego.TabIndex = 2;
            this.labelNombreJuego.Text = "(Nombre)";
            this.labelNombreJuego.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor del juego:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilustrador del juego:";
            // 
            // labelAutorJuego
            // 
            this.labelAutorJuego.AutoSize = true;
            this.labelAutorJuego.Location = new System.Drawing.Point(470, 111);
            this.labelAutorJuego.Name = "labelAutorJuego";
            this.labelAutorJuego.Size = new System.Drawing.Size(68, 17);
            this.labelAutorJuego.TabIndex = 5;
            this.labelAutorJuego.Text = "(Nombre)";
            // 
            // labelIlustradorJuego
            // 
            this.labelIlustradorJuego.AutoSize = true;
            this.labelIlustradorJuego.Location = new System.Drawing.Point(470, 153);
            this.labelIlustradorJuego.Name = "labelIlustradorJuego";
            this.labelIlustradorJuego.Size = new System.Drawing.Size(68, 17);
            this.labelIlustradorJuego.TabIndex = 6;
            this.labelIlustradorJuego.Text = "(Nombre)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.treeViewAutores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelDatosJuegoElegido.ResumeLayout(false);
            this.panelDatosJuegoElegido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenJuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeViewAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.ListView listViewContenidos;
        private System.Windows.Forms.ImageList imageListAutores;
        private System.Windows.Forms.ImageList imageListContendioListView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panelDatosJuegoElegido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxImagenJuego;
        private System.Windows.Forms.Label labelNombreJuego;
        private System.Windows.Forms.Label labelIlustradorJuego;
        private System.Windows.Forms.Label labelAutorJuego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

