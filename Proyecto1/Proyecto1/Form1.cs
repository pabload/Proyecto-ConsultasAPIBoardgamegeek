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
using System.Threading;
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
        Usuario nuevoUsuario;
        //public Dictionary<String, String> ListaJuegoAutor = new Dictionary<String, String>();

        public Image Image { get; private set; }

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
                listViewContenidos.Clear();
                listViewContenidos.BringToFront();
                labelInformacionInferior.Text = "Cargando por favor espere..........";
                nuevoUsuario = new Usuario(textBoxNombreUsuario.Text, directorioCacheUsuarios,directorioCacheJuegos);
                Console.WriteLine(treeViewAutores.Nodes.Count+"aaaaaaaaaaaaaaaaaaaaaaaa");
                if (nuevoUsuario.nombre.Length >0)
                {
                    CrearNodos(nuevoUsuario);
                    MessageBox.Show("ya termino");
                }
                else
                {

                    MessageBox.Show("NO EXISTE");
                    textBoxNombreUsuario.Text = "";
                    listViewContenidos.Items.Clear();
                    treeViewAutores.Nodes.Clear();
                }
                      
            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe en boton: " + ex);
                Console.WriteLine("error en: " + ex);
            }
        }

        private void CrearNodos(Usuario nuevoUsuario)
        {
            treeViewAutores.Nodes.Add("Autores", "Autores", "IconoAuto.png", "IconoAuto.png");
            treeViewAutores.Nodes.Add("Juegos", "Juegos", "juegos-de-mesa.png", "juegos-de-mesa.png");
            InsertarNodosAutores(nuevoUsuario);
            InsertarNodos(nuevoUsuario, "Juegos","Categorias",nuevoUsuario.listaCategorias);
            InsertarNodos(nuevoUsuario, "Juegos", "Familias", nuevoUsuario.listaFamilias);
            InsertarNodos(nuevoUsuario, "Juegos", "Mecanicas", nuevoUsuario.listaMecanicas);
            InsertarNodos(nuevoUsuario, "Juegos", "Numero de jugadores", nuevoUsuario.listaNumeroJugadores);
            progressBar1.Value = 0;
            labelInformacionInferior.Text = "Informacion cargada correctamenete";



        }

        private void InsertarNodos(Usuario nuevoUsuario,String nodoPadre,String clasificacion, Dictionary<String, ArrayList> diccionario)
        {
            try
            {
                TreeNode nuevoNodoPadre = treeViewAutores.Nodes[nodoPadre].Nodes.Add(clasificacion, clasificacion, "juegos-de-mesa.png", "juegos-de-mesa.png");
                nuevoNodoPadre.Tag = diccionario;
                foreach (KeyValuePair<String, ArrayList> clasifi in diccionario)
                {

                    TreeNode nuevonodo = treeViewAutores.Nodes[nodoPadre].Nodes[clasificacion].Nodes.Add(clasifi.Key, clasifi.Key, "juegos-de-mesa.png", "juegos-de-mesa.png");
                    nuevonodo.Tag = clasifi.Value;
                    ArrayList ArregloJuegos = (ArrayList)nuevonodo.Tag;
                    foreach (ColeccionJuegosUsuario juego in ArregloJuegos)
                    {

                        imageListTreeview.Images.Add(juego.idjuego, Image.FromFile(juego.linkimagen));
                        TreeNode nuevoHijo = treeViewAutores.Nodes[nodoPadre].Nodes[clasificacion].Nodes[clasifi.Key].Nodes.Add(juego.idjuego, juego.nombreJuego, juego.idjuego, juego.idjuego);
                        nuevoHijo.Tag = juego;
                    }
                  
                }
                progressBar1.Value = progressBar1.Value + 20;
            }
            catch(Exception ex)
            {
                MessageBox.Show("erro aki bro: "+ex);
            }

        }
        private void InsertarNodosAutores(Usuario nuevoUsuario)
        {

            //treeViewAutores.Nodes.Add("Autores", "Autores", "IconoAuto.png", "IconoAuto.png");
            foreach (KeyValuePair<string, ArrayList> Autor in nuevoUsuario.listaAutores)
            {
                TreeNode nuevonodo = treeViewAutores.Nodes["Autores"].Nodes.Add(Autor.Key, Autor.Key, 0, 0);
                nuevonodo.Tag = Autor.Value;
                ArrayList juegosDeAutor = Autor.Value;
                foreach (ColeccionJuegosUsuario juego in juegosDeAutor)
                {

                    imageListTreeview.Images.Add(juego.idjuego,Image.FromFile(juego.linkimagen));
                    TreeNode nuevoHijo = treeViewAutores.Nodes["Autores"].Nodes[Autor.Key].Nodes.Add(juego.idjuego, juego.nombreJuego, juego.idjuego,juego.idjuego);
                    nuevoHijo.Tag = juego;
                }
              
            }
            progressBar1.Value = progressBar1.Value + 20;
        }

        private void TreeViewAutores_AfterSelect(object sender, TreeViewEventArgs e) {

            listViewContenidos.Items.Clear();
            if (e.Node.Parent == null)
            {
                String nombreNodo = e.Node.Text;
                switch (nombreNodo) {

                    case  "Autores":
                    CargarAutores(e.Node);
                    break;
                    case "Juegos":
                    MessageBox.Show("ENTRO AKI");
                    CargarClasifiacionJuegos(e.Node);
                    break;
                }
            }
            else
            {
                if(e.Node.Tag is ColeccionJuegosUsuario)
                {
                    ColeccionJuegosUsuario juego = (ColeccionJuegosUsuario)e.Node.Tag;
                    CargarJuegoSeleccionado(juego);
                }
                if (e.Node.Tag is ArrayList)
                {
                    ArrayList JuegosAutor = (ArrayList)e.Node.Tag;
                    CargarJuegosClasificacionSeleccionada(JuegosAutor);
                }
                if (e.Node.Tag is Dictionary<String, ArrayList>)
                {
                    Dictionary<String, ArrayList> ListaNumJuego = (Dictionary<String, ArrayList>)e.Node.Tag;
                    CargarClasifiacionDejuegosPorNumeroJugadores(ListaNumJuego);
                }

                /*if (e.Node.Text.Equals("Numero de jugadores"))
                    {
                        MessageBox.Show("madre mia willy"+ e.Node.Tag.ToString());
                        Dictionary<String, ArrayList> ListaNumJuego = (Dictionary<String, ArrayList>)e.Node.Tag;
                        CargarClasifiacionDejuegosPorNumeroJugadores(ListaNumJuego);

                    }*/

                
            }          
            
        }

        private void CargarClasifiacionDejuegosPorNumeroJugadores(Dictionary<string, ArrayList> listaNumJuego)
        {
            listViewContenidos.Items.Clear();
            foreach (KeyValuePair<string, ArrayList> numeroJugadores in listaNumJuego)
            {
                panelDatosJuegoElegido.SendToBack();
                ListViewItem item = new ListViewItem(numeroJugadores.Key, "juegos-de-mesa.png");
                item.Tag = numeroJugadores.Value;
                listViewContenidos.Items.Add(item);
            }
        }

        private void CargarJuegoSeleccionado(ColeccionJuegosUsuario juego)
        {
          listViewContenidos.Items.Clear();
          panelDatosJuegoElegido.BringToFront();
          labelNombreJuego.Text = juego.nombreJuego;
          textBoxAutoresJuego.Clear();
          textBoxIlustradoresJuego.Clear();
          int contador = 0;
          foreach (String autor in juego.listaDeAutores)
          {
              contador++;
              textBoxAutoresJuego.AppendText(autor);

              if (contador < juego.listaDeAutores.Count)
              {
                  textBoxAutoresJuego.AppendText(Environment.NewLine);
              }

          }
          contador = 0;
          foreach (String ilustradores in juego.listaDeilustradores)
          {
              contador++;
              textBoxIlustradoresJuego.AppendText(ilustradores);

              if (contador < juego.listaDeilustradores.Count)
              {
                  textBoxIlustradoresJuego.AppendText(Environment.NewLine);
              }

          }
          pictureBoxImagenJuego.Image = Image.FromFile(juego.linkimagen);


        }

        private void CargarJuegosClasificacionSeleccionada(ArrayList Juegos)
        {
            listViewContenidos.Items.Clear();
            foreach (ColeccionJuegosUsuario juegoAutor in Juegos)
          {
                panelDatosJuegoElegido.SendToBack();
                imageListContendioListView.Images.Add(juegoAutor.idjuego, Image.FromFile(juegoAutor.linkimagen));
                ListViewItem item = new ListViewItem(juegoAutor.nombreJuego, juegoAutor.idjuego);
                item.SubItems.Add(juegoAutor.idjuego);
                item.Tag = juegoAutor;
                Console.WriteLine(juegoAutor.linkimagen+"aaaaaaaaaaaaaaa");
                imageListContendioListView.Images.Add(Image.FromFile(juegoAutor.linkimagen));
                listViewContenidos.Items.Add(item);
            }
            
        }

        private void CargarAutores(TreeNode node)
        {
           
            panelDatosJuegoElegido.SendToBack();
            foreach (TreeNode Autor in node.Nodes)
            {
                treeViewAutores.SelectedNode = null;

                ListViewItem item = new ListViewItem(Autor.Text, 0);

                item.Tag = Autor.Tag;
                item.ImageKey = "IconoAuto.png";
                listViewContenidos.Items.Add(item);
                treeViewAutores.SelectedNode = null;
            }
        }
        private void CargarClasifiacionJuegos(TreeNode node)
        {
            panelDatosJuegoElegido.SendToBack();
            foreach (TreeNode clasificacion in node.Nodes)
            {
                treeViewAutores.SelectedNode = null;

                ListViewItem item = new ListViewItem(clasificacion.Text, 1);

                item.Tag = clasificacion.Tag;
                item.ImageKey = "juegos-de-mesa.png";
                listViewContenidos.Items.Add(item);
                treeViewAutores.SelectedNode = null;
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
 
        }

        private void ListViewContenidos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void ListViewContenidos_Click(object sender, EventArgs e)
        {
            if (listViewContenidos.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = listViewContenidos.SelectedItems[0];
                MessageBox.Show(itemSeleccionado.Tag.GetType().ToString());
                if (itemSeleccionado.Tag is ArrayList)
                {
                    ArrayList juegos = (ArrayList)itemSeleccionado.Tag;
                    CargarJuegosClasificacionSeleccionada(juegos);
                }
                if (itemSeleccionado.Tag is ColeccionJuegosUsuario)
                {
                    ColeccionJuegosUsuario juego = (ColeccionJuegosUsuario)itemSeleccionado.Tag;
                    CargarJuegoSeleccionado(juego);
                }
                if (itemSeleccionado.Tag is Dictionary<String, ArrayList>)
                {
                      Dictionary<String, ArrayList> ListaNumJuego = (Dictionary<String, ArrayList>)itemSeleccionado.Tag;
                    CargarClasifiacionDejuegosPorNumeroJugadores(ListaNumJuego);
                }
            }
        }

        private void TreeViewAutores_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
         
        }

        private void TreeViewAutores_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
           
        }
    }
}
