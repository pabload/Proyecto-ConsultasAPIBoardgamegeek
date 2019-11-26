using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Adversario
    {
        public String nombreJuego;
        public String idjuego;
        public int numeroTotalPartidas;
        public int vecesGanadas;
        public int vecesPerdidas;
        public Adversario(String nom, String id,int ganadas, int perdidas,int totalPartidas)
        {
            nombreJuego = nom;
            idjuego = id;
            vecesGanadas = ganadas;
            vecesPerdidas = perdidas;
            numeroTotalPartidas = totalPartidas;
        }
    }
}
