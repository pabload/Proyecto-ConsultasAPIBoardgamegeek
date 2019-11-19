using System;
using System.Web;
using System.Xml;
using System.Net;
using System.IO;
public class Consultas
{
    public Consultas()
    {
    }
    private static XmlDocument consultarAPI(string URL)
    {
        int delay = 500;
        WebResponse respuesta = null;
        while (respuesta == null)
        {
            try
            {
                WebRequest peticion = WebRequest.Create(URL);
                respuesta = peticion.GetResponse();
            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(delay);
                delay += 500;
            }
        }
        Stream flujo = respuesta.GetResponseStream();
        StreamReader lectorFlujo = new StreamReader(flujo);
        string cadenaRespuesta = lectorFlujo.ReadToEnd();
        XmlDocument xmlRespuesta = new XmlDocument();
        xmlRespuesta.LoadXml(cadenaRespuesta);
        return xmlRespuesta; 

    }
    public static XmlDocument consultarAPIUsuario(string usuario)
    {
        string URLConsulta = "https://boardgamegeek.com/xmlapi2/user?name=" + usuario;
        return consultarAPI(URLConsulta);

    }
    public static XmlDocument consultarAPIJuego(string id)
    {
        string URLConsulta = "https://boardgamegeek.com/xmlapi2/thing?id=" + id;
        return consultarAPI(URLConsulta);

    }
    public static XmlDocument consultarAPIColeccionJuegosUsuario(string nombre)
    {
        string URLConsulta = "https://www.boardgamegeek.com/xmlapi2/collection?username=" +nombre+"&own=1";
        return consultarAPI(URLConsulta);

    }
    public static XmlDocument consultarDatosJuego(string IdJuego)
    {
        string URLConsulta = "https://boardgamegeek.com/xmlapi2/thing?id=" + IdJuego;
        return consultarAPI(URLConsulta);

    }
}
