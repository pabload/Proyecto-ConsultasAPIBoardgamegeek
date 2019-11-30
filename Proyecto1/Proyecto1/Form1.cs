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
        int numerodeJuegos =0;
        public Dictionary<String, Image> ListaImagenes = new Dictionary<String, Image>();

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
                LimpiarTodo();
                nuevoUsuario = new Usuario(textBoxNombreUsuario.Text, directorioCacheUsuarios,directorioCacheJuegos);
                labelInformacionInferior.Text = "Cargando por favor espere..........";
                Console.WriteLine(treeViewAutores.Nodes.Count+"aaaaaaaaaaaaaaaaaaaaaaaa");
                if (nuevoUsuario.nombre.Length >0)
                {
                    Console.WriteLine("Empezo");
                    CrearNodos(nuevoUsuario);
                    //MessageBox.Show("ya termino");
                }
                else
                {

                    MessageBox.Show("NO EXISTE");
                    textBoxNombreUsuario.Text = "";
                    listViewContenidos.Items.Clear();
                    treeViewAutores.Nodes.Clear();
                }
                MessageBox.Show(nuevoUsuario.listaAdversarios.Count.ToString());
                foreach (KeyValuePair<String, ArrayList> adversario in nuevoUsuario.listaAdversarios)
                {
                    Console.WriteLine(adversario.Key+" tiene: "+adversario.Value.Count);
                    //MessageBox.Show(adversario.Key + " tiene: " + adversario.Value.Count);
                    foreach(Adversario infoad in adversario.Value)
                    {
                        Console.WriteLine("idjuego: "+infoad.idjuego+" nombre adversario: "+adversario.Key);
                        Console.WriteLine("el adversario gano: " + infoad.vecesGanadasdelAdversario + " perdio: " + infoad.vecesPerdidadelAdversario);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erroe en boton: " + ex);
                Console.WriteLine("error en: " + ex);
            }
        }

        private void LimpiarTodo()
        {
            ListaImagenes.Clear();
            treeViewAutores.Nodes.Clear();
            listViewContenidos.Clear();
            listViewContenidos.BringToFront();
            imageListTreeview.Images.Clear();
            Image ImagenAutores = Image.FromFile("IconoAuto.png");
            Image ImagenJuegos = Image.FromFile("juegos-de-mesa.png");
            Image ImagenFamilias = Image.FromFile("familia.png");
            Image ImagenMecanicas = Image.FromFile("mecanicas.png");
            Image ImagenNumJugadores = Image.FromFile("numJugadores.png");
            Image ImagenCategorias = Image.FromFile("categoria.png");
            Image ImagenAdversario = Image.FromFile("adversario.png");
            imageListTreeview.Images.Add("IconoAuto.png", ImagenAutores);
            imageListTreeview.Images.Add("juegos-de-mesa.png", ImagenJuegos);
            imageListTreeview.Images.Add("familia.png", ImagenFamilias);
            imageListTreeview.Images.Add("mecanicas.png", ImagenMecanicas);
            imageListTreeview.Images.Add("numJugadores.png", ImagenNumJugadores);
            imageListTreeview.Images.Add("Categorias.png", ImagenCategorias);
            imageListTreeview.Images.Add("adversario.png", ImagenAdversario);
            imageListContendioListView.Images.Add("IconoAuto.png", ImagenAutores);
            imageListContendioListView.Images.Add("juegos-de-mesa.png", ImagenJuegos);
            imageListContendioListView.Images.Add("familia.png", ImagenFamilias);
            imageListContendioListView.Images.Add("mecanicas.png", ImagenMecanicas);
            imageListContendioListView.Images.Add("numJugadores.png", ImagenNumJugadores);
            imageListContendioListView.Images.Add("Categorias.png", ImagenCategorias);
            imageListContendioListView.Images.Add("adversario.png", ImagenAdversario);
        }

        private void CrearNodos(Usuario nuevoUsuario)
        {
            treeViewAutores.Nodes.Add("Autores", "Autores", "IconoAuto.png", "IconoAuto.png");
            treeViewAutores.Nodes.Add("Juegos", "Juegos", "juegos-de-mesa.png", "juegos-de-mesa.png");
            treeViewAutores.Nodes.Add("Adversarios", "Adversarios", "adversario.png", "adversario.png");
            InsertarNodosAutores(nuevoUsuario);
            MessageBox.Show((imageListTreeview.Images.Count-6).ToString());
            numerodeJuegos = 0;
            InsertarNodos(nuevoUsuario, "Juegos", "Familias", nuevoUsuario.listaFamilias, "familia.png");
            InsertarNodos(nuevoUsuario, "Juegos", "Mecanicas", nuevoUsuario.listaMecanicas, "mecanicas.png");
            InsertarNodos(nuevoUsuario, "Juegos", "Numero de jugadores", nuevoUsuario.listaNumeroJugadores, "numJugadores.png");
            InsertarNodos(nuevoUsuario, "Juegos", "Categorias", nuevoUsuario.listaCategorias, "Categorias.png");
            InsertarNodosAdversariosJuegos(nuevoUsuario, "Adversarios", "Juegos jugados con adversarios", nuevoUsuario.listaAdversarios, "juegos-de-mesa.png");
            InsertarNodosAdversario(nuevoUsuario, "Adversarios", "Nombres de los adversarios", nuevoUsuario.listaAdversarios, "adversario.png");
            progressBar1.Value = 0;
            labelInformacionInferior.Text = "Informacion cargada correctamenete";



        }

        private void InsertarNodosAdversario(Usuario nuevoUsuario, String nodoPadre, String clasificacion, Dictionary<String, ArrayList> diccionario, String keyImagenNodo)
        {
            try
            {
                TreeNode nuevoNodoPadre = treeViewAutores.Nodes[nodoPadre].Nodes.Add(clasificacion, clasificacion, keyImagenNodo, keyImagenNodo);
                nuevoNodoPadre.Tag = diccionario;
                foreach (KeyValuePair<String, ArrayList> adversario in diccionario)
                {
                   TreeNode nuevoAdversario = nuevoNodoPadre.Nodes.Add(adversario.Key, adversario.Key, "adversario.png", "adversario.png");
                   nuevoAdversario.Tag = adversario.Value;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro aki bro: " + ex);
            }
        }

        private void InsertarNodosAdversariosJuegos(Usuario nuevoUsuario, String nodoPadre, String clasificacion, Dictionary<String, ArrayList> diccionario, String keyImagenNodo)
        {
            try
            {
                TreeNode nuevoNodoPadre = treeViewAutores.Nodes[nodoPadre].Nodes.Add(clasificacion, clasificacion, keyImagenNodo, keyImagenNodo);
                nuevoNodoPadre.Tag = diccionario;
                foreach (KeyValuePair<String, ArrayList> adversario in diccionario)
                {
                    ArrayList juegosAd = adversario.Value;
                    String nombreAdversario = adversario.Key;
                    foreach (Adversario juegoad in juegosAd)
                    {
                        TreeNode nuevoJuegoAd = new TreeNode(juegoad.nombreJuego);
                       
                        if (!nuevoNodoPadre.Nodes.ContainsKey(nuevoJuegoAd.Text))
                        {
                            ArrayList listaAdversariosJuego = new ArrayList();
                            TreeNode nuevonodoJuego= nuevoNodoPadre.Nodes.Add(juegoad.nombreJuego, juegoad.nombreJuego, juegoad.idjuego, juegoad.idjuego);
                            TreeNode nuevoAdversario = nuevoNodoPadre.Nodes[juegoad.nombreJuego].Nodes.Add(adversario.Key, adversario.Key, "adversario.png", "adversario.png");
                            nuevoAdversario.Tag = juegoad;
                            listaAdversariosJuego.Add(juegoad);
                            nuevonodoJuego.Tag = listaAdversariosJuego;
                        }
                        else
                        {
                            if (nuevoNodoPadre.Nodes.ContainsKey(nuevoJuegoAd.Text))
                            {
                                TreeNode nuevoAdversario = nuevoNodoPadre.Nodes[nuevoJuegoAd.Text].Nodes.Add(adversario.Key, adversario.Key, "adversario.png", "adversario.png");
                                nuevoAdversario.Tag = juegoad;
                                ArrayList listaAdversariosJuego = (ArrayList)nuevoNodoPadre.Nodes[nuevoJuegoAd.Text].Tag;
                                listaAdversariosJuego.Add(juegoad);
                            }
                        }
                    }

                }
                MessageBox.Show(nuevoNodoPadre.Nodes.Count.ToString()+"aaaaaaaaaaaaaaa");
                //progressBar1.Value = progressBar1.Value + 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro aki bro: " + ex);
            }
        }

        private void InsertarNodos(Usuario nuevoUsuario,String nodoPadre,String clasificacion, Dictionary<String, ArrayList> diccionario,String keyImagenNodo)
        {
            try
            {
                TreeNode nuevoNodoPadre = treeViewAutores.Nodes[nodoPadre].Nodes.Add(clasificacion, clasificacion, keyImagenNodo,keyImagenNodo);
                nuevoNodoPadre.Tag = diccionario;
                foreach (KeyValuePair<String, ArrayList> clasifi in diccionario)
                {

                    TreeNode nuevonodo = treeViewAutores.Nodes[nodoPadre].Nodes[clasificacion].Nodes.Add(clasifi.Key, clasifi.Key, keyImagenNodo, keyImagenNodo);
                    nuevonodo.Tag = clasifi.Value;
                    ArrayList ArregloJuegos = (ArrayList)nuevonodo.Tag;
                    foreach (ColeccionJuegosUsuario juego in ArregloJuegos)
                    {

                        TreeNode nuevoHijo = treeViewAutores.Nodes[nodoPadre].Nodes[clasificacion].Nodes[clasifi.Key].Nodes.Add(juego.idjuego, juego.nombreJuego, juego.idjuego, juego.idjuego);
                        nuevoHijo.Tag = juego;
                    }
                  
                }
                //progressBar1.Value = progressBar1.Value + 20;
            }
            catch(Exception ex)
            {
                MessageBox.Show("erro aki bro: "+ex);
            }

        }
        private void InsertarNodosAutores(Usuario nuevoUsuario)
        {

            foreach (KeyValuePair<string, ArrayList> Autor in nuevoUsuario.listaAutores)
            {
                TreeNode nuevonodo = treeViewAutores.Nodes["Autores"].Nodes.Add(Autor.Key, Autor.Key, 0, 0);
                nuevonodo.Tag = Autor.Value;
                ArrayList juegosDeAutor = Autor.Value;
                foreach (ColeccionJuegosUsuario juego in juegosDeAutor)
                {
                   
                    if (!imageListTreeview.Images.ContainsKey(juego.idjuego))
                    {
                       imageListTreeview.Images.Add(juego.idjuego, juego.imagenJuego);
                        ListaImagenes.Add(juego.idjuego, juego.imagenJuego);
                        Console.WriteLine(juego.nombreJuego);
                    }
                    TreeNode nuevoHijo = treeViewAutores.Nodes["Autores"].Nodes[Autor.Key].Nodes.Add(juego.idjuego, juego.nombreJuego, juego.idjuego,juego.idjuego);
                    nuevoHijo.Tag = juego;
                }
              
            }
            //progressBar1.Value = progressBar1.Value + 20;
            
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
                    CargarClasifiacionJuegos(e.Node);
                    break;
                    case "Adversarios":
                    CargarNombreJuegosAdversario(e.Node);
                    break;
                }
            }
            else
            {

                if (e.Node.Text.Equals("Juegos jugados con adversarios") || e.Node.Text.Equals("Nombres de los adversarios")||e.Node.Parent.Text.Equals("Juegos jugados con adversarios")||e.Node.Tag is Adversario|| e.Node.Parent.Text.Equals("Nombres de los adversarios"))
                {              
                    if (e.Node.Text.Equals("Juegos jugados con adversarios"))
                    {
                        CargarJuegosJugadosPorAdversario(e.Node);
                    }
                    if (e.Node.Parent.Text.Equals("Juegos jugados con adversarios"))
                    {
                        CargarAdversarioJuegoSeleccionado(e.Node);
                    }
                    if (e.Node.Tag is Adversario)
                    {
                        MessageBox.Show("es adversario");
                        Adversario info = (Adversario)e.Node.Tag;
                        Console.WriteLine(info.nombreJuego);
                    }
                    if (e.Node.Text.Equals("Nombres de los adversarios"))
                    {
                        CargarAdversarios(e.Node);
                      
                    }
                    if (e.Node.Parent.Text.Equals("Nombres de los adversarios"))
                    {
                        MessageBox.Show("adversario"+e.Node.Tag.ToString());
                        //CargarAdversarios(e.Node);

                    }
                }
                else
                {
                    if (e.Node.Tag is ColeccionJuegosUsuario)
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
                        CargarClasifiacionDejuegosPorNumeroJugadores(ListaNumJuego, e.Node.ImageKey);
                    }
                }                
            }          
            
        }

        private void CargarAdversarioJuegoSeleccionado(TreeNode node)
        {
            listViewContenidos.Clear();
            foreach (TreeNode Adversario in node.Nodes)
            {
                panelDatosJuegoElegido.SendToBack();
                Adversario infoAd = (Adversario)Adversario.Tag;
                ListViewItem item = new ListViewItem(Adversario.Text, "adversario.png");
                item.Tag = infoAd;
                listViewContenidos.Items.Add(item);
            }
        }

        private void CargarAdversarios(TreeNode node)
        {
            listViewContenidos.Clear();
            foreach (TreeNode adversario in node.Nodes)
            {
                panelDatosJuegoElegido.SendToBack();
                ArrayList info = (ArrayList)adversario.Tag;
                ListViewItem item = new ListViewItem(adversario.Text, "adversario.png");
                item.Tag = info;
                listViewContenidos.Items.Add(item);
            }
        }

        private void CargarJuegosJugadosPorAdversario(TreeNode node)
        {
            listViewContenidos.Clear();
            foreach (TreeNode juego in node.Nodes)
            {
                //MessageBox.Show("entro" + juego.Tag.ToString());
                panelDatosJuegoElegido.SendToBack();
                ArrayList info = (ArrayList)juego.Tag;
                Image imagejuego = ListaImagenes[juego.ImageKey];
                imageListContendioListView.Images.Add(juego.ImageKey, imagejuego);
                ListViewItem item = new ListViewItem(juego.Text, juego.ImageKey);
                item.Tag = info;
                listViewContenidos.Items.Add(item);
            }
            
        }

        private void CargarNombreJuegosAdversario(TreeNode node)
        {
            panelDatosJuegoElegido.SendToBack();
            foreach (TreeNode tipo in node.Nodes)
            {
                if (tipo.Text == "Juegos jugados con adversarios")
                {

                    ListViewItem item = new ListViewItem(tipo.Text, 1);
                    item.Tag = tipo.Tag;
                    MessageBox.Show(item.Tag.ToString());
                    item.ImageKey = "juegos-de-mesa.png";
                    listViewContenidos.Items.Add(item);
                    treeViewAutores.SelectedNode = null;
                }
                else
                {
                    ListViewItem item = new ListViewItem(tipo.Text, "adversario.png");

                    item.Tag = tipo.Tag;
                    item.ImageKey = "adversario.png";
                    listViewContenidos.Items.Add(item);
                    treeViewAutores.SelectedNode = null;
                }

            }
        }

        private void CargarClasifiacionDejuegosPorNumeroJugadores(Dictionary<string, ArrayList> listaNumJuego,String keyimagen)
        {
            listViewContenidos.Items.Clear();
            MessageBox.Show(keyimagen);
            foreach (KeyValuePair<string, ArrayList> numeroJugadores in listaNumJuego)
            {
                panelDatosJuegoElegido.SendToBack();
                ListViewItem item = new ListViewItem(numeroJugadores.Key, keyimagen);
                item.Tag = numeroJugadores.Value;
                listViewContenidos.Items.Add(item);
            }
        }

        private void CargarJuegoSeleccionado(ColeccionJuegosUsuario juego)
        {
          listViewContenidos.Items.Clear();
          panelDatosJuegoElegido.BringToFront();
          textBoxAutoresJuego.Clear();
          textBoxIlustradoresJuego.Clear();
          richTextBoxDescripcionJuego.Clear();
          dataGridView1.Rows.Clear();
          labelNombreJuego.Text = juego.nombreJuego;
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
          pictureBoxImagenJuego.Image = juego.imagenJuego;
          richTextBoxDescripcionJuego.Text = juego.descripcionJuego;
          Console.WriteLine("numeros de veces jugadaaaaaaaas " + juego.numeroDePartidas);
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"+juego.juegosJugadosPorNumeroJugador.Count);
            Console.WriteLine(juego.idjuego);
            labelNumeroTotalPartidas.Text = juego.numeroDePartidas.ToString();
          foreach (KeyValuePair<String, InfoPartidas> PartidaconNumJugadores in juego.juegosJugadosPorNumeroJugador)
            {
                dataGridView1.Rows.Add(PartidaconNumJugadores.Key, PartidaconNumJugadores.Value.partidasGanadas, PartidaconNumJugadores.Value.partidasPerdidas);
            }

        }
        private void CargarJuegosClasificacionSeleccionada(ArrayList Juegos)
        {
            
            listViewContenidos.Items.Clear();
            foreach (ColeccionJuegosUsuario juegoAutor in Juegos)
          {
                panelDatosJuegoElegido.SendToBack();
                imageListContendioListView.Images.Add(juegoAutor.idjuego, juegoAutor.imagenJuego);
                ListViewItem item = new ListViewItem(juegoAutor.nombreJuego, juegoAutor.idjuego);
                item.SubItems.Add(juegoAutor.idjuego);
                item.Tag = juegoAutor;
                Console.WriteLine(juegoAutor.linkimagen+"aaaaaaaaaaaaaaa");
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
            int c = 1;
            foreach (TreeNode clasificacion in node.Nodes)
            {
                treeViewAutores.SelectedNode = null;

                ListViewItem item = new ListViewItem(clasificacion.Text, clasificacion.ImageKey);

                item.Tag = clasificacion.Tag;
                item.ImageKey = clasificacion.ImageKey;
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
                //MessageBox.Show(itemSeleccionado.Tag.ToString());
                //////////////adversarios/////////////////////////////////////
                if(itemSeleccionado.Text.Equals("Juegos jugados con adversarios")|| (itemSeleccionado.Text.Equals("Nombres de los adversarios")))
                {
                    if(itemSeleccionado.Text.Equals("Juegos jugados con adversarios"))
                    {
                        TreeNode nodoreferencia = treeViewAutores.Nodes["Adversarios"].Nodes["Juegos jugados con adversarios"];
                        CargarJuegosJugadosPorAdversario(nodoreferencia);
                    }
                    if (itemSeleccionado.Text.Equals("Nombres de los adversarios"))
                    {
                        TreeNode nodoreferencia = treeViewAutores.Nodes["Adversarios"].Nodes["Nombres de los adversarios"];
                        CargarAdversarios(nodoreferencia);
                    }



                }
                /////////////////////////////////////////////////////////////////////
                else
                {
                 if (itemSeleccionado.Tag is ArrayList)
                    {
                        
                        ArrayList lista = (ArrayList)itemSeleccionado.Tag;
                        if(lista[0] is ColeccionJuegosUsuario)
                        {
                            CargarJuegosClasificacionSeleccionada(lista);
                        }
                        if (lista[0] is Adversario &&!itemSeleccionado.ImageKey.Equals("adversario.png"))
                        {
                            MessageBox.Show("entro");
                            TreeNode nodoreferencia = treeViewAutores.Nodes["Adversarios"].Nodes["Juegos jugados con adversarios"].Nodes[itemSeleccionado.Text];
                            CargarAdversarioJuegoSeleccionado(nodoreferencia);

                        }
                    }
                    if(itemSeleccionado.Tag is Adversario)
                    {
                       
                       
                        //MessageBox.Show("hola juego:"+info.nombreJuego+"perdidad: "+info.vecesGanadasdelAdversario +"gano "+info.vecesPerdidadelAdversario);
                    }
                    if (itemSeleccionado.Tag is ColeccionJuegosUsuario)
                    {
                        
                        ColeccionJuegosUsuario juego = (ColeccionJuegosUsuario)itemSeleccionado.Tag;
                        CargarJuegoSeleccionado(juego);
                    }
                    if (itemSeleccionado.Tag is Dictionary<String, ArrayList>)
                    {
                        MessageBox.Show("eeeeeee");
                        Dictionary<String, ArrayList> ListaNumJuego = (Dictionary<String, ArrayList>)itemSeleccionado.Tag;
                        CargarClasifiacionDejuegosPorNumeroJugadores(ListaNumJuego, itemSeleccionado.ImageKey);
                    }

                }
            }
        }

        private void TreeViewAutores_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
         
        }

        private void TreeViewAutores_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
