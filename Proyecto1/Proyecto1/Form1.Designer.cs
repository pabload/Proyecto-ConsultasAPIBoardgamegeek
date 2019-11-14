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
            this.imageListContendioListView = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
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
            this.listViewContenidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContenidos.LargeImageList = this.imageListContendioListView;
            this.listViewContenidos.Location = new System.Drawing.Point(209, 86);
            this.listViewContenidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewContenidos.Name = "listViewContenidos";
            this.listViewContenidos.Size = new System.Drawing.Size(858, 436);
            this.listViewContenidos.SmallImageList = this.imageListContendioListView;
            this.listViewContenidos.TabIndex = 5;
            this.listViewContenidos.UseCompatibleStateImageBehavior = false;
            // 
            // imageListContendioListView
            // 
            this.imageListContendioListView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListContendioListView.ImageSize = new System.Drawing.Size(50, 50);
            this.imageListContendioListView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listViewContenidos);
            this.Controls.Add(this.treeViewAutores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

