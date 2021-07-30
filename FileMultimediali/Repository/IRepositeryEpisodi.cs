using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    interface IRepositeryEpisodi

    {
        static List<EpisodioPodcast> episodiPodcast = new List<EpisodioPodcast>
        {
            new EpisodioPodcast ("AB01", new Durata(0, 32, 04), false),
            new EpisodioPodcast ("AB02", new Durata(0, 12, 04) , false),
            new EpisodioPodcast ("AB03", new Durata(0, 37, 04), false),
            new EpisodioPodcast ("AB04", new Durata(0, 42, 04), false),
        };
       
        public List<EpisodioPodcast> Fetch()
        {
            return episodiPodcast;
        }
    }
}
