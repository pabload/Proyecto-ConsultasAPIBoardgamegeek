using System;
using System.Xml;
using System.IO;
using System.Collections;

using System.Windows.Forms;
using System.Net;
using System.Threading;
using Analizador;
using System.Collections.Generic;

public class Usuario
{
    public String nombreDelUsuario;
    public String nombre;
    public String apellidos;
    public String fechaRegistro;
    public Dictionary<String, ArrayList> listaAutores = new Dictionary<String,ArrayList>();
    public Dictionary<String, ArrayList> listaNumeroJugadores = new Dictionary<String, ArrayList>();
    public Dictionary<String, ArrayList> listaMecanicas = new Dictionary<String, ArrayList>();
    public Dictionary<String, ArrayList> listaFamilias = new Dictionary<String, ArrayList>();
    public Dictionary<String, ArrayList> listaCategorias = new Dictionary<String,ArrayList>();
    public String rutaDeCacheUsuarios;
    Boolean archivosEstaEnCache = true;
    XmlDocument documentoUsuario= new XmlDocument();
    XmlDocument documentoJuegosUsuario = new XmlDocument();
    XmlDocument documentoDatosJuego =  new XmlDocument();
    public Usuario(String nombreUsuario, String rutaCacheUsuarios, String rutaCacheJuegos)
    {
        ComprobarExistenciaCache(nombreUsuario, rutaCacheUsuarios);
        AlamacenarDatosUsuario(rutaCacheJuegos);
    }
    private void ComprobarExistenciaCache(string nombreUsuario, string rutaCacheUsuarios)
    {
        if (File.Exists(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario))
        {
            CargarArchivosCache(nombreUsuario, rutaCacheUsuarios);
            archivosEstaEnCache = true;
        }
        else
        {
            CargarArchivosAPI(nombreUsuario, rutaCacheUsuarios);
            archivosEstaEnCache = false;
        }
    }

    private void CargarArchivosAPI(string nombreUsuario, string rutaCacheUsuarios)
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
        if (nombre.Length != 0)
        {
            ObtenerJuegosdeColeccion(archivosEstaEnCache,rutaCacheJuegos);
        }
        else
        {
            MessageBox.Show("ENTRO 1");
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
                if (ComprobarExistenciaCache == false)
                {
                    WebClient cliente = new WebClient();
                    cliente.DownloadFile(link, rutaCacheJuegos + "imagen_" + idJuego + ".jpg");
                }
                link = rutaCacheJuegos + "imagen_" + idJuego + ".jpg";
                ColeccionJuegosUsuario NuevoJuego = new ColeccionJuegosUsuario(nombreJuego, link, idJuego);
                TomarAutoresDatosJuego(NuevoJuego, rutaCacheJuegos);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRRO" + e);
            }
            Thread.Sleep(400);
        }
        MessageBox.Show("ya termino");
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
            XmlNodeList autores = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamedesigner']");
            XmlNodeList Ilustradores = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgameartist']");
            XmlNodeList numeroJugadores = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/poll[@name='suggested_numplayers']/results");
            XmlNodeList Mecanicas = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamemechanic']");
            XmlNodeList familias = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamefamily']");
            XmlNodeList Categorias = documentoDatosJuego.DocumentElement.SelectNodes("/items/item/link[@type='boardgamecategory']");
            GuardarInformacionDiccionario(autores, listaAutores, Juego, Juego.listaDeAutores,"value");
            GuardarInformacionDiccionario(numeroJugadores, listaNumeroJugadores, Juego, Juego.listaDeNumeroJugadores, "numplayers");
            GuardarInformacionDiccionario(Mecanicas, listaMecanicas, Juego, Juego.listaDeMecanicas, "value");
            GuardarInformacionDiccionario(familias, listaFamilias, Juego, Juego.listaDeFamilia, "value");
            GuardarInformacionDiccionario(Categorias, listaCategorias, Juego, Juego.listaDeCategoria, "value");
            foreach (XmlNode ilustrador in Ilustradores)
            {
                String nombreilustrador = ilustrador.Attributes["value"].Value;
                Juego.listaDeilustradores.Add(nombreilustrador);
               
            }
            documentoDatosJuego.Save(rutaCacheJuegos + "DatosDeJuego_" + Juego.idjuego);
        }
        catch(Exception ex)
        {
            MessageBox.Show("aki de error"+ex);
        }

    }

    private void GuardarInformacionDiccionario(XmlNodeList lista, Dictionary<String, ArrayList> diccionario, ColeccionJuegosUsuario juego,ArrayList listadelJuego,String valorAtomar)
    {
        foreach (XmlNode nodo in lista)
        {
            String nombreElemento = nodo.Attributes[valorAtomar].Value;
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