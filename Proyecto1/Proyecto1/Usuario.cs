using System;
using System.Xml;
using System.IO;
using System.Collections;

using System.Windows.Forms;
using System.Net;
using System.Threading;
using Analizador;
using System.Collections.Generic;
using System.Drawing;
using Proyecto1;

public class Usuario
{
    public String nombreDelUsuario;
    public String nombre;
    public String apellidos;
    public String fechaRegistro;
    public String idDelUsuario;
    public Dictionary<String, Image> ImagenesJuegos = new Dictionary<String, Image>();
    public Dictionary<String, ArrayList> listaAutores = new Dictionary<String,ArrayList>();
    public Dictionary<String, ArrayList> listaNumeroJugadores = new Dictionary<String, ArrayList>();
    public Dictionary<String, ArrayList> listaMecanicas = new Dictionary<String, ArrayList>();
    public Dictionary<String, ArrayList> listaFamilias = new Dictionary<String, ArrayList>();
    public Dictionary<String, ArrayList> listaCategorias = new Dictionary<String,ArrayList>();
    public Dictionary<String, ArrayList> listaAdversarios = new Dictionary<String,ArrayList>();
    public String rutaDeCacheUsuarios;
    Boolean archivosEstaEnCache = true;
    XmlDocument documentoUsuario= new XmlDocument();
    XmlDocument documentoJuegosUsuario = new XmlDocument();
    XmlDocument documentoDatosJuego =  new XmlDocument();
    XmlDocument documentoPartidasJuego = new XmlDocument();
    int c = 0;
    public Boolean Continuar = false;
    public Usuario(String nombreUsuario, String rutaCacheUsuarios, String rutaCacheJuegos)
    {
        rutaDeCacheUsuarios = rutaCacheUsuarios;
        nombreDelUsuario = nombreUsuario;
        ComprobarExistenciaCache(nombreUsuario, rutaCacheUsuarios);
        if (Continuar == true)
        {
          AlamacenarDatosUsuario(rutaCacheJuegos);
          
        }
    }
    private void ComprobarExistenciaCache(string nombreUsuario, string rutaCacheUsuarios)
    {
        if (File.Exists(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario))
        {
            CargarArchivosCache(nombreUsuario, rutaCacheUsuarios);
            archivosEstaEnCache = true;
            Continuar = true;
        }
        else
        {
            if (VerificarConexion()== true)
            {
                CargarArchivosAPI(nombreUsuario, rutaCacheUsuarios);
                archivosEstaEnCache = false;
                Continuar = true;
            }
            else
            {
                MessageBox.Show("No cuentas con conexion y el usuario no se encuentra en cache");
                Continuar = false; 
            }
        }
    }

    private void CargarArchivosAPI(string nombreUsuario, string rutaCacheUsuarios)
    {
       try
        {
            Console.WriteLine("entro al elseEEEEEE");
            documentoUsuario = Consultas.consultarAPIUsuario(nombreUsuario);
            documentoJuegosUsuario = Consultas.consultarAPIColeccionJuegosUsuario(nombreUsuario);
            nombre = documentoUsuario.DocumentElement.SelectSingleNode("/user/firstname").Attributes[0].Value;
            if (nombre.Length != 0)
            {
                Directory.CreateDirectory(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/");
                documentoUsuario.Save(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario);
                documentoJuegosUsuario.Save(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + "ColeccionJuegos_" + nombreUsuario);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("erro es " + ex);
        }
    }

    private void CargarArchivosCache(string nombreUsuario, string rutaCacheUsuarios)
    {
        documentoUsuario.Load(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario);
        documentoJuegosUsuario.Load(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + "ColeccionJuegos_" + nombreUsuario);
    }
    private void AlamacenarDatosUsuario(String rutaCacheJuegos)
    {
        nombre = documentoUsuario.DocumentElement.SelectSingleNode("/user/firstname").Attributes[0].Value;
        apellidos = documentoUsuario.DocumentElement.SelectSingleNode("/user/lastname").Attributes[0].Value;
        fechaRegistro = documentoUsuario.DocumentElement.SelectSingleNode("/user/yearregistered").Attributes[0].Value;
        idDelUsuario = documentoUsuario.DocumentElement.SelectSingleNode("/user").Attributes["id"].Value;
        //MessageBox.Show(idDelUsuario);
        if (nombre.Length != 0)
        {
            ObtenerJuegosdeColeccion(archivosEstaEnCache,rutaCacheJuegos);
        }
        else
        {
            //MessageBox.Show("ENTRO 1");
            return;
        }
    }

    private void ObtenerJuegosdeColeccion(Boolean ComprobarExistenciaCache, String rutaCacheJuegos)
    {
        XmlNodeList juegos = documentoJuegosUsuario.DocumentElement.SelectNodes("/items/item[@objecttype='thing']");
        foreach (XmlNode juego in juegos)
        {
            String nombreJuego = juego.SelectSingleNode("name").InnerText;
            String link = juego.SelectSingleNode("thumbnail").InnerText;
            String idJuego = juego.Attributes["objectid"].Value;
            try
            {
                if (ComprobarExistenciaCache == false&&!File.Exists(rutaCacheJuegos + "imagen_" + idJuego + ".jpg"))
                {
                    c++;
                    Console.WriteLine("no esta en cache"+c);
                    WebClient cliente = new WebClient();
                    cliente.DownloadFile(link, rutaCacheJuegos + "imagen_" + idJuego + ".jpg");
                    Thread.Sleep(900);
                    
                }
                link = rutaCacheJuegos + "imagen_" + idJuego + ".jpg";
                Image imagenjuego = Image.FromFile(link);
                ImagenesJuegos.Add(idJuego, imagenjuego);
                ColeccionJuegosUsuario NuevoJuego = new ColeccionJuegosUsuario(nombreJuego, imagenjuego, idJuego);
                TomarAutoresDatosJuego(NuevoJuego, rutaCacheJuegos);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRRO" + e);
            }
        }
        //MessageBox.Show("ya termino");
    }

    private void TomarAutoresDatosJuego(ColeccionJuegosUsuario Juego,String rutaCacheJuegos)
    {
        try
        {
            documentoDatosJuego = new XmlDocument();
            if(File.Exists(rutaCacheJuegos+ "DatosDeJuego_" + Juego.idjuego))
            {
                documentoDatosJuego.Load(rutaCacheJuegos + "DatosDeJuego_" + Juego.idjuego);
            }
            else
            {
                documentoDatosJuego = Consultas.consultarDatosJuego(Juego.idjuego);
            }
            Juego.descripcionJuego = documentoDatosJuego.DocumentElement.SelectSingleNode("/items/item/description").InnerText;
            XmlNodeList autores = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamedesigner']");
            XmlNodeList Ilustradores = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgameartist']");
            XmlNodeList numeroJugadores = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/poll[@name='suggested_numplayers']/results");
            XmlNodeList Mecanicas = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamemechanic']");
            XmlNodeList familias = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamefamily']");
            XmlNodeList Categorias = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamecategory']");
            GuardarInformacionDiccionario(autores, listaAutores, Juego, Juego.listaDeAutores,"value","autores");
            GuardarInformacionDiccionario(numeroJugadores, listaNumeroJugadores, Juego, Juego.listaDeNumeroJugadores, "numplayers", "numeroJugadores");
            GuardarInformacionDiccionario(Mecanicas, listaMecanicas, Juego, Juego.listaDeMecanicas, "value", "Mecanicas");
            GuardarInformacionDiccionario(familias, listaFamilias, Juego, Juego.listaDeFamilia, "value", "familias");
            GuardarInformacionDiccionario(Categorias, listaCategorias, Juego, Juego.listaDeCategoria, "value", "Categorias");
            RegistrarJuegosJugados(Juego, nombre);
            foreach (XmlNode ilustrador in Ilustradores)
            {
                String nombreilustrador = ilustrador.Attributes["value"].Value;
                Juego.listaDeilustradores.Add(nombreilustrador);
               
            }
            documentoDatosJuego.Save(rutaCacheJuegos + "DatosDeJuego_" + Juego.idjuego);
        }
        catch(Exception ex)
        {
            MessageBox.Show("erro en "+ex);
        }

    }

    private void RegistrarJuegosJugados(ColeccionJuegosUsuario juego, string nombre)
    {
        try
        {
            if (File.Exists(rutaDeCacheUsuarios + "/Carpeta_" + nombreDelUsuario + "/" + "PartidasJuego_" + juego.idjuego))
            {
                string fecha = File.GetLastWriteTime(rutaDeCacheUsuarios + "/Carpeta_" + nombreDelUsuario + "/" + "PartidasJuego_" + juego.idjuego).ToString("dd-MM-yyyy");
                if (!fecha.Equals(DateTime.Today.ToString("dd-MM-yyyy")))
                {
                    Console.WriteLine("se Actulizo Partidas");
                    documentoPartidasJuego = Consultas.consultarDatosPartidasJuego(nombreDelUsuario, juego.idjuego);
                }
                else
                {
                    Console.WriteLine("No se actualizo");
                    documentoPartidasJuego.Load(rutaDeCacheUsuarios + "/Carpeta_" + nombreDelUsuario + "/" + "PartidasJuego_" + juego.idjuego);
                }
            }
            else
            {
                documentoPartidasJuego = Consultas.consultarDatosPartidasJuego(nombreDelUsuario, juego.idjuego);
            }
            juego.numeroDePartidas= int.Parse(documentoPartidasJuego.DocumentElement.SelectSingleNode("/plays").Attributes["total"].Value);
            XmlNodeList listaPartidas = documentoPartidasJuego.DocumentElement.SelectNodes("/plays/play");
            foreach (XmlNode partida in listaPartidas)
            {
                XmlNodeList listaJugadoresPartida = partida.SelectNodes("players/player");
                String idPartida = partida.Attributes["id"].Value;
                int numeroJugadores = listaJugadoresPartida.Count;
                String NombreGanadorPartida = "";
                String idGanadorPartida = "";
                ArrayList ganadoresPartidas = new ArrayList();
                int contadorvictorias = 0;
                Boolean GanoUsuario =VerificarSiUsarioGano(listaJugadoresPartida,idPartida,juego.nombreJuego);
                foreach (XmlNode jugador in listaJugadoresPartida)
                {
                    String NombreJugadorPartida = jugador.Attributes["name"].Value;
                    String idUsuarioJugador = jugador.Attributes["userid"].Value;
                    int resultadoPartida = 0;
                    Boolean gano = false;
                    if (jugador.Attributes["win"].Value.Equals("1"))
                    {
                        resultadoPartida = 1;
                        NombreGanadorPartida = NombreJugadorPartida;
                        idGanadorPartida = idUsuarioJugador;
                        ganadoresPartidas.Add(NombreGanadorPartida);
                        gano = true;
                        contadorvictorias++;
                    }
                    if (NombreJugadorPartida.ToLower().Equals(nombre)||idUsuarioJugador.Equals(idDelUsuario))
                    {
                        if (!juego.juegosJugadosPorNumeroJugador.ContainsKey(numeroJugadores.ToString()))
                        {
                            InfoPartidas infp = new InfoPartidas(1, resultadoPartida, 1-resultadoPartida);
                            juego.juegosJugadosPorNumeroJugador.Add(numeroJugadores.ToString(),infp);
                            Console.WriteLine("se guardo" + numeroJugadores.ToString() + " juagadores");
                          
                        }
                        else
                        {
                            juego.juegosJugadosPorNumeroJugador[numeroJugadores.ToString()].NumeroTotalPartidasPorNumeroJugadores++;
                            juego.juegosJugadosPorNumeroJugador[numeroJugadores.ToString()].partidasGanadas = juego.juegosJugadosPorNumeroJugador[numeroJugadores.ToString()].partidasGanadas + resultadoPartida;
                            juego.juegosJugadosPorNumeroJugador[numeroJugadores.ToString()].partidasPerdidas = juego.juegosJugadosPorNumeroJugador[numeroJugadores.ToString()].NumeroTotalPartidasPorNumeroJugadores - juego.juegosJugadosPorNumeroJugador[numeroJugadores.ToString()].partidasGanadas;

                        }
                      
                    }
                    /////////////////////////////////////////////////////////////////////////////////////////////////////
                    if (!NombreJugadorPartida.ToLower().Equals(nombre)&&!idUsuarioJugador.Equals(idDelUsuario))
                    {
                        if (NombreJugadorPartida.Equals(""))
                        {
                            NombreJugadorPartida = "Sin nombre registrados";
                        }
                        if (!listaAdversarios.ContainsKey(NombreJugadorPartida)){
                            if (gano == true)
                            {
                                Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego,juego.imagenJuego, NombreGanadorPartida,1, 0, 1);
                                infojuegoad.NombresganadoresPartidas.Add(NombreGanadorPartida);
                                infojuegoad.IdsganadoresPartidas.Add(idGanadorPartida);
                                ArrayList juegosAd = new ArrayList();
                                juegosAd.Add(infojuegoad);
                                listaAdversarios.Add(NombreGanadorPartida, juegosAd);
                            }
                            else
                            {
                                //Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, NombreJugadorPartida, 0, 0, 1);
                                Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, NombreJugadorPartida, 0, 0, 1);
                                   ArrayList juegosAd = new ArrayList();
                                   juegosAd.Add(infojuegoad);
                                   listaAdversarios.Add(NombreJugadorPartida, juegosAd);
                                if (GanoUsuario == true)
                                {
                                    infojuegoad.vecesPerdidadelAdversario++;
                                    /*Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, NombreJugadorPartida, 0, 1, 1);
                                    ArrayList juegosAd = new ArrayList();
                                    juegosAd.Add(infojuegoad);
                                    listaAdversarios.Add(NombreJugadorPartida, juegosAd);*/
                                }                         
                            }
                        }
                        else
                        {
                            ArrayList juegosAd = listaAdversarios[NombreJugadorPartida];
                            Boolean EstaJuegolista = false;
                             foreach(Adversario juegoaAd in juegosAd)
                            {
                                if (juegoaAd.nombreJuego.Equals(juego.nombreJuego))
                                {
                                    EstaJuegolista = true;
                                    juegoaAd.numeroTotalPartidas++;
                                    if (gano == true)
                                    {                    
                                        juegoaAd.vecesGanadasdelAdversario++;
                                    }
                                    else
                                    {
                                        if (GanoUsuario == true)
                                        {
                                            juegoaAd.vecesPerdidadelAdversario++;
                                        }
                                                             
                                    }
                                }
                            }
                            if (EstaJuegolista == false)
                            {
                                if (gano == true)
                                {
                                    Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego,juego.imagenJuego ,NombreJugadorPartida,1, 0, 1);
                                    listaAdversarios[NombreJugadorPartida].Add(infojuegoad);
                                }
                                else
                                {
                                    Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, NombreJugadorPartida, 0, 0, 1);
                                    listaAdversarios[NombreJugadorPartida].Add(infojuegoad);
                                    if (GanoUsuario == true)
                                    {
                                        /* Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, NombreJugadorPartida, 0, 1, 1);
                                         listaAdversarios[NombreJugadorPartida].Add(infojuegoad);*/
                                        infojuegoad.vecesPerdidadelAdversario++;
                                    }
                                               
                                }
                            }
                        }
                    }

                }
                if(juego.listaDeMecanicas.Contains("Cooperative Game"))
                {
                    if (contadorvictorias == 0)
                    {
                        if (!listaAdversarios.ContainsKey(juego.nombreJuego))
                        {
                            Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, juego.nombreJuego, 1, 0, 1);
                            ArrayList juegosAd = new ArrayList();
                            juegosAd.Add(infojuegoad);
                            listaAdversarios.Add(juego.nombreJuego, juegosAd);
                        }
                        else
                        {
                            ArrayList lista = listaAdversarios[juego.nombreJuego];
                            Adversario info = (Adversario)lista[0];
                            info.vecesGanadasdelAdversario++;

                        }
                    }
                    else
                    {
                        if (!listaAdversarios.ContainsKey(juego.nombreJuego))
                        {
                            Adversario infojuegoad = new Adversario(juego.nombreJuego, juego.idjuego, juego.imagenJuego, juego.nombreJuego, 0, 1, 1);
                            ArrayList juegosAd = new ArrayList();
                            juegosAd.Add(infojuegoad);
                            listaAdversarios.Add(juego.nombreJuego, juegosAd);
                        }
                        else
                        {
                            ArrayList lista = listaAdversarios[juego.nombreJuego];
                            Adversario info = (Adversario)lista[0];
                            info.vecesPerdidadelAdversario++;

                        }
                    }
                
                }
            }
            documentoPartidasJuego.Save(rutaDeCacheUsuarios + "/Carpeta_" + nombreDelUsuario + "/" + "PartidasJuego_" + juego.idjuego);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    private Boolean VerificarSiUsarioGano(XmlNodeList listaJugadoresPartida,String idPartida,String nombrejuego)
    {
        Boolean ganoUsario = false;
        ArrayList adversarios = new ArrayList();
        foreach (XmlNode jugador in listaJugadoresPartida)
        {
            String NombreJugadorPartida = jugador.Attributes["name"].Value;
            String idUsuarioJugador = jugador.Attributes["userid"].Value;
            if (jugador.Attributes["win"].Value.Equals("1")&&(NombreJugadorPartida.ToLower().Equals(nombre)||idUsuarioJugador.Equals(idDelUsuario)))
            {
                //MessageBox.Show("gano juandalf  "+idPartida+" "+nombrejuego);
                return ganoUsario = true;

            }        
        }

        return ganoUsario;                          
    }
 

    private void GuardarInformacionDiccionario(XmlNodeList lista, Dictionary<String, ArrayList> diccionario, ColeccionJuegosUsuario juego,ArrayList listadelJuego,String valorAtomar,String nombrelistaNodo)
    {
        if (lista.Count == 0)
        {
            String nombreElemento="";
            switch (nombrelistaNodo)
            {
                case "autores" :
                nombreElemento = "(Uncredited)";
                break;
                case "Mecanicas":
                nombreElemento = "sin mecaninas";
                break;
                case "numeroJugadores":
                nombreElemento = "sin numero de juegadores";
                break;
                case "familias":
                nombreElemento = "sin familias";
                break;
                case "Categorias":
                nombreElemento = "sin categorias";
                break;
            }
            listadelJuego.Add(nombreElemento);
            if (diccionario.ContainsKey(nombreElemento))
            {
                diccionario[nombreElemento].Add(juego);

            }
            else
            {
                ArrayList NuevaListaDiccionario = new ArrayList();
                diccionario.Add(nombreElemento, NuevaListaDiccionario);
                diccionario[nombreElemento].Add(juego);
            }
        }
        else
        {
            foreach (XmlNode nodo in lista)
            {
                String nombreElemento = nodo.Attributes[valorAtomar].Value;
                Console.WriteLine(nombrelistaNodo);
                if (nombrelistaNodo.Equals("numeroJugadores"))
                {
                    if (nombreElemento.Contains("+"))
                    {
                        return;
                    }
                }
                listadelJuego.Add(nombreElemento);
                if (diccionario.ContainsKey(nombreElemento))
                {
                    diccionario[nombreElemento].Add(juego);

                }
                else
                {
                    ArrayList NuevaListaDiccionario = new ArrayList();
                    diccionario.Add(nombreElemento, NuevaListaDiccionario);
                    diccionario[nombreElemento].Add(juego);
                }


            }
        }
    }
    public static bool VerificarConexion()
    {
        try
        {
            using (var client = new WebClient())
            using (var stream = client.OpenRead("http://www.google.com"))
            {
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}