using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Adversario
    {
        public String nombreJuego;
        public String idjuego;
        public Image imagenJuego;
        public String nombreAdversario; 
        public int numeroTotalPartidas;
        public int vecesGanadasdelAdversario;
        public int vecesPerdidadelAdversario;
        public Adversario(String nom, String id,Image imagen,String adversario,int ganadas, int perdidas,int totalPartidas)
        {
            nombreJuego = nom;
            idjuego = id;
            vecesGanadasdelAdversario = ganadas;
            vecesPerdidadelAdversario = perdidas;
            numeroTotalPartidas = totalPartidas;
            imagenJuego = imagen;
            nombreAdversario = adversario;
        }
    }
}
