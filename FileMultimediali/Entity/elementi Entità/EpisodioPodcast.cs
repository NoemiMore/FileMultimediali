using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class EpisodioPodcast
    {
        public string TitoloEpisodio { get; set; }

        public Durata DurataEpisodio { get; set; }

        public bool Flag { get; set; }

        public EpisodioPodcast(string titoloEpisodio, Durata durataEpisodio, bool flag) 
        { TitoloEpisodio = titoloEpisodio;
            DurataEpisodio = durataEpisodio;
            Flag = flag;
        }
    }



    public struct Durata
    {
        public int Ore { get; set; }
        public int Minuti { get; set; }
        public int Secondi { get; set; }

        public Durata(int ore, int min, int sec)
        {
            Ore = ore;
            Minuti = min;
            Secondi = sec;
        }
    }
}
