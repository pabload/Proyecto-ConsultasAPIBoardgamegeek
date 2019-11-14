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
                Usuario nuevoUsuario = new Usuario(textBoxNombreUsuario.Text, directorioCacheUsuarios,directorioCacheJuegos);
                if (nuevoUsuario.nombre.Length >0)
                {
                    Console.WriteLine("Este vergas tiene este numero de autore: " + nuevoUsuario.listaAutores.Count);
                    treeViewAutores.Nodes.Clear();
                    int contador = 0;
                    foreach (KeyValuePair<string, ArrayList> Autor in nuevoUsuario.listaAutores)
                    {

                        Console.WriteLine(Autor.Key);
                        TreeNode nuevoNodo = new TreeNode(Autor.Key, 0, 0);
                        nuevoNodo.Tag = Autor.Value;
                        //treeViewAutores.Nodes[0].Nodes.Add(Autor.Key);
                        treeViewAutores.Nodes.Add(nuevoNodo);
                        ArrayList juegosDeAutor = Autor.Value;
                        //Console.WriteLine("esta madre es el key "+Autor.Key);
                        String algo = Autor.Key;
                        foreach (ColeccionJuegosUsuario juego in juegosDeAutor)
                        {
                         
                            imageListAutores.Images.Add(Image.FromFile(juego.linkimagen));
                            int indexNuevaImage = imageListAutores.Images.Count - 1;
                            //TreeNode nuevoHijo = treeViewAutores.Nodes[contador].Nodes.Add()
                            TreeNode nuevoHijo = treeViewAutores.Nodes[contador].Nodes.Add(juego.idjuego, juego.nombreJuego, indexNuevaImage);
                            nuevoHijo.Tag = juego.idjuego;
                           
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
            if (e.Node.Nodes.Count != 0)
            {
                foreach (TreeNode juegoAutor in e.Node.Nodes)
                {
                    XmlDocument documentoJuego = new XmlDocument();
                    documentoJuego.Load(directorioCacheJuegos + "DatosDeJuego_" + juegoAutor.Tag);
                    String nombre = documentoJuego.DocumentElement.SelectSingleNode("/items/item/name[@type='primary']").Attributes["value"].Value;
                    String autor = documentoJuego.DocumentElement.SelectSingleNode("/items/item/link[@type='boardgamedesigner']").Attributes["value"].Value;
                    String ilustrador = documentoJuego.DocumentElement.SelectSingleNode("/items/item/link[@type='boardgameartist']").Attributes["value"].Value;
                    String linkimagen = directorioCacheJuegos + "imagen_" + juegoAutor.Tag + ".jpg";
                    Console.WriteLine(linkimagen);
                    ListViewItem item = new ListViewItem(juegoAutor.Text, imageListContendioListView.Images.Count);
                    imageListContendioListView.Images.Add(Image.FromFile(linkimagen));
                    listViewContenidos.Items.Add(item);
                }
            }
            else
            {
                Console.WriteLine("este es un juego");
            }
        }
    }
}
