using Analizador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        String directorioCache = Application.LocalUserAppDataPath;
        String directorioCacheUsuarios;
        String directorioCacheJuegos;
        public Dictionary<String, String> ListaJuegoAutor = new Dictionary<String, String>();
        void AsegurarExistenciaDirectorioCacheUsuarios()
        {
            directorioCache = Application.LocalUserAppDataPath;
            directorioCacheUsuarios = directorioCache + "/usuarios/";
            Console.WriteLine("entro aki");
            if (!Directory.Exists(directorioCacheUsuarios))
            {
                Directory.CreateDirectory(directorioCacheUsuarios);

            }
        }
        void AsegurarExistenciaDirectorioCacheJuegos()
        {
            directorioCache = Application.LocalUserAppDataPath;
            directorioCacheJuegos = directorioCache + "/juegos/";
            if (!Directory.Exists(directorioCacheJuegos))
            {
                Directory.CreateDirectory(directorioCacheJuegos);

            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AsegurarExistenciaDirectorioCacheUsuarios();
            AsegurarExistenciaDirectorioCacheJuegos();

        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewAutores.Nodes.Clear();
                Usuario nuevoUsuario = new Usuario(textBoxNombreUsuario.Text, directorioCacheUsuarios,directorioCacheJuegos);
                TreeNode nodoAutores = new TreeNode("Autores", 0, 0);
                nodoAutores.Tag = "nodoPadreAutor";
                treeViewAutores.Nodes.Add(nodoAutores);
                Console.WriteLine(treeViewAutores.Nodes.Count+"aaaaaaaaaaaaaaaaaaaaaaaa");
                if (nuevoUsuario.nombre.Length >0)
                {
                  
                  
                    int contador = 0;
                    foreach (KeyValuePair<string, ArrayList> Autor in nuevoUsuario.listaAutores)
                    {

                        Console.WriteLine(Autor.Key);
                        TreeNode nuevoNodo = new TreeNode(Autor.Key,0,0);
                        nuevoNodo.Tag = Autor.Value;
                        //treeViewAutores.Nodes[0].Nodes.Add(Autor.Key);
                        //treeViewAutores.Nodes.Add(nuevoNodo);
                        treeViewAutores.Nodes[0].Nodes.Add(nuevoNodo);
                        ArrayList juegosDeAutor = Autor.Value;
                        //Console.WriteLine("esta madre es el key "+Autor.Key);
                        //String algo = Autor.Key;
                        foreach (ColeccionJuegosUsuario juego in juegosDeAutor)
                        {
                         
                            imageListAutores.Images.Add(Image.FromFile(juego.linkimagen));
                            int indexNuevaImage = imageListAutores.Images.Count - 1;
                            //TreeNode nuevoHijo = treeViewAutores.Nodes[contador].Nodes.Add()
                            TreeNode nuevoHijo = treeViewAutores.Nodes[0].Nodes[contador].Nodes.Add(juego.idjuego, juego.nombreJuego, indexNuevaImage);
                            //nuevoHijo.Tag = juego.idjuego;
                            nuevoHijo.Tag = juego;
                        }
                        contador++;
                    }

                }
                else
                {
                    MessageBox.Show("NO EXISTE");
                }
                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe en boton: " + ex);
                Console.WriteLine("error en: " + ex);
            }
        }

        private void TreeViewAutores_AfterSelect(object sender, TreeViewEventArgs e) {
       
            listViewContenidos.Items.Clear();
            if (e.Node.Tag != "nodoPadreAutor")
            {
                if (e.Node.Nodes.Count != 0)
                {
        
                    int contandorJuegos = 0;
                    foreach (TreeNode juegoAutor in e.Node.Nodes)
                    {
                        panelDatosJuegoElegido.SendToBack();
                        XmlDocument documentoJuego = new XmlDocument();
                        ColeccionJuegosUsuario juego = (ColeccionJuegosUsuario)juegoAutor.Tag;
                        ListViewItem item = new ListViewItem(juegoAutor.Text, imageListContendioListView.Images.Count);
                        item.Tag = juego;
                        //item.SubItems.Add(autor);
                        //item.SubItems.Add(ilustrador);
                        Console.WriteLine(imageListContendioListView.Images.Count+"LOL");
                        imageListContendioListView.Images.Add(Image.FromFile(juego.linkimagen));
                        listViewContenidos.Items.Add(item);
                        contandorJuegos++;
                    }
                }
                else
                {
                    ColeccionJuegosUsuario juego = (ColeccionJuegosUsuario)e.Node.Tag;
                    panelDatosJuegoElegido.BringToFront();
                    labelAutorJuego.Text = juego.nombreJuego;
                    pictureBoxImagenJuego.Image = Image.FromFile(juego.linkimagen);
                }
            }
            else
            {
                Console.WriteLine("ES AUTOR");
                panelDatosJuegoElegido.SendToBack();
                foreach (TreeNode Autor in e.Node.Nodes)
                {
                    treeViewAutores.SelectedNode = null;

                    ListViewItem item = new ListViewItem(Autor.Text,0);
                    item.Tag = Autor.Tag;
                    listViewContenidos.Items.Add(item);
                    treeViewAutores.SelectedNode = null;
                }
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listViewContenidos.View = View.SmallIcon;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listViewContenidos.View = View.Details;
            //listViewContenidos.View = View.Tile;
            //listViewContenidos.View = View.List;
        }

        private void ListViewContenidos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewContenidos.SelectedItems.Count > 0)
            {
                if (listViewContenidos.SelectedItems[0].ImageIndex == 0)
                {
                    ArrayList listaJuegos = (ArrayList)listViewContenidos.SelectedItems[0].Tag;
                    listViewContenidos.Items.Clear();
                    foreach (ColeccionJuegosUsuario juegoAutor in listaJuegos)
                    {
                        ListViewItem item = new ListViewItem(juegoAutor.nombreJuego, imageListContendioListView.Images.Count);
                        //item.SubItems.Add(autor);
                        //item.SubItems.Add(ilustrador);
                        Console.WriteLine(imageListContendioListView.Images.Count);
                        imageListContendioListView.Images.Add(Image.FromFile(juegoAutor.linkimagen));
                        item.Tag = juegoAutor;
                        listViewContenidos.Items.Add(item);
                        //listViewContenidos.Items.Clear();
                        //Console.WriteLine(nombre + "aaaaaaaaaaaaaaaaa");
                        //Console.WriteLine(treeViewAutores.Nodes[0].Nodes[nombre]);

                    }

                }
                else
                {
                   
                    ColeccionJuegosUsuario juego = (ColeccionJuegosUsuario)listViewContenidos.SelectedItems[0].Tag;
                    //Console.WriteLine(listViewContenidos.SelectedItems[0].Tag+"SSSSSS");
                    panelDatosJuegoElegido.BringToFront();
                    labelAutorJuego.Text = juego.nombreJuego;
                    pictureBoxImagenJuego.Image = Image.FromFile(juego.linkimagen);
                }
             

            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
