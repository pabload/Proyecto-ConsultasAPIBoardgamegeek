using Proyecto1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador
{
    class ColeccionJuegosUsuario
    {
        public String nombreJuego;
        public String linkimagen;
        public String idjuego;
        public Image imagenJuego;
        public String descripcionJuego;
        public int  numeroDePartidas;
        public ArrayList listaDeAutores = new ArrayList();
        public ArrayList listaDeilustradores = new ArrayList();
        public ArrayList listaDeNumeroJugadores = new ArrayList();
        public Dictionary<String,InfoPartidas> juegosJugadosPorNumeroJugador = new Dictionary<String,InfoPartidas>();
        public Dictionary<String, InfoPartidas> juegosJugadosAdversariosPorNumeroJugador = new Dictionary<string, InfoPartidas>();
        public ArrayList listaDeMecanicas = new ArrayList();
        public ArrayList listaDeFamilia = new ArrayList();
        public ArrayList listaDeCategoria = new ArrayList();
        
        public ColeccionJuegosUsuario(String nombre, Image imagen, String id)
        {
            nombreJuego = nombre;
            imagenJuego = imagen;
            idjuego = id;
        }


    }
}
