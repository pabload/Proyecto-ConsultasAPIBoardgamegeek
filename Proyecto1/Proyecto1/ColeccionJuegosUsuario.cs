using System;
using System.Collections;
using System.Collections.Generic;
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
        public ArrayList listaDeAutores = new ArrayList();
        public ArrayList listaDeilustradores = new ArrayList();
        public ArrayList listaDeNumeroJugadores = new ArrayList();
        public ArrayList listaDeMecanicas = new ArrayList();
        public ArrayList listaDeFamilia = new ArrayList();
        public ArrayList listaDeCategoria = new ArrayList();
        public ColeccionJuegosUsuario(String nombre, String link, String id)
        {
            nombreJuego = nombre;
            linkimagen = link;
            idjuego = id;
        }


    }
}
