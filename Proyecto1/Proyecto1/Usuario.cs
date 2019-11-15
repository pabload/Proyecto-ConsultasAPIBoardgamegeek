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
    public String usuarioBGG;
    public String linkImagenJuego;
    public Dictionary<String, ArrayList> listaAutores = new Dictionary<String,ArrayList>();
    public String rutaDeCacheUsuarios;
    XmlDocument documentoUsuario= new XmlDocument();
    XmlDocument documentoJuegosUsuario = new XmlDocument();
    XmlDocument documentoDatosJuego =  new XmlDocument();
    public Usuario(String nombreUsuario, String rutaCacheUsuarios, String rutaCacheJuegos)
    {

        rutaDeCacheUsuarios = rutaCacheUsuarios;
        Boolean juegoEstaEnCache = true;
        if (File.Exists(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario))
        {
            Console.WriteLine("entro al ifFFFFFFFF");
            documentoUsuario.Load(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario);
            documentoJuegosUsuario.Load(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + "ColeccionJuegos_" + nombreUsuario);

        }
        else
        {
            juegoEstaEnCache = false;
            Console.WriteLine("entro al elseEEEEEE");
            Directory.CreateDirectory(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/");
            documentoUsuario = Consultas.consultarAPIUsuario(nombreUsuario);
            documentoJuegosUsuario = Consultas.consultarAPIColeccionJuegosUsuario(nombreUsuario);

        }
        nombre = documentoUsuario.DocumentElement.SelectSingleNode("/user/firstname").Attributes[0].Value;
        apellidos = documentoUsuario.DocumentElement.SelectSingleNode("/user/lastname").Attributes[0].Value;
        fechaRegistro = documentoUsuario.DocumentElement.SelectSingleNode("/user/yearregistered").Attributes[0].Value;
        if (nombre.Length != 0)
        {
            nombreDelUsuario = nombreUsuario;
            XmlNodeList juegos = documentoJuegosUsuario.DocumentElement.SelectNodes("/items/item[@objecttype='thing']");
            int c = 0;
            foreach (XmlNode juego in juegos)
            {
                String nombreJuego = juego.SelectSingleNode("name").InnerText;
                String link = juego.SelectSingleNode("thumbnail").InnerText;
                String idJuego = juego.Attributes["objectid"].Value;
                try
                {
                    if (juegoEstaEnCache == false)
                    {
                        WebClient cliente = new WebClient();
                        cliente.DownloadFile(link, rutaCacheJuegos+"imagen_"+ idJuego + ".jpg");
                        Console.WriteLine("este es el link de la imagen" + link);
                        Console.WriteLine("este es su nombre" + nombreJuego);
                        c++;
                        Console.WriteLine("van " + c + " imagenes guardadas");

                    }

                    link = rutaCacheJuegos + "imagen_" + idJuego + ".jpg";
                    Console.WriteLine("este es el link de la imagen" + link);
                    Console.WriteLine("este es su nombre" + nombreJuego);
                    ColeccionJuegosUsuario NuevoJuego = new ColeccionJuegosUsuario(nombreJuego, link, idJuego);
                    TomarAutoresJuego(NuevoJuego,rutaCacheJuegos);
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERRRO"+e);
                }
                Thread.Sleep(500);
            }

            documentoUsuario.Save(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + nombreUsuario);
            documentoJuegosUsuario.Save(rutaCacheUsuarios + "/Carpeta_" + nombreUsuario + "/" + "ColeccionJuegos_" + nombreUsuario);
        }
        else
        {
            MessageBox.Show("ENTRO 1");
        }
       
    }

    private void TomarAutoresJuego(ColeccionJuegosUsuario Juego,String rutaCacheJuegos)
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
            foreach (XmlNode autor in autores)
            {
                String nombreAutor = autor.Attributes["value"].Value;

                if (listaAutores.ContainsKey(nombreAutor))
                {
                    listaAutores[nombreAutor].Add(Juego);

                }
                else
                {
                    ArrayList juegosAutor = new ArrayList();
                    listaAutores.Add(nombreAutor, juegosAutor);
                    listaAutores[nombreAutor].Add(Juego);
                }


            }
            documentoDatosJuego.Save(rutaCacheJuegos + "DatosDeJuego_" + Juego.idjuego);
        }
        catch
        {
            MessageBox.Show("aki de error");
        }

    }
  
}