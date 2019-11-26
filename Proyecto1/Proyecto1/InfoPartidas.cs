using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class InfoPartidas
    {
        public int NumeroTotalPartidasPorNumeroJugadores;
        public int partidasGanadas;
        public int partidasPerdidas;

         public InfoPartidas(int numPartidas, int pg, int pp)
        {
            NumeroTotalPartidasPorNumeroJugadores = numPartidas;
            partidasGanadas = pg;
            partidasPerdidas = pp;
        }

    }
