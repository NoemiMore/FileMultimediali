using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class RepositeryPodcast :  IRepositeryEpisodi, IDbRepositery <Podcast>
    {

        static List<Podcast> listaPodcast = new List<Podcast>
        {
            new Podcast ("Marco","calro", 37, "jfmsnjnfj", "nfhbbbdhfnnfj snndb"),
            new Podcast ("Mttrco","Giogndji", 22, "jfmsnjnfj", "nfhbbbdhfnnfj snndb"),
            new Podcast ("Manfnco","Gionni", 32, "jfmsnjnfj", "nfhbbbdhfnnfj snndb"),
            new Podcast ("Mco","Gionni", 42, "jfmsnjnfj", "nfhbbbdhfnnfj snndb"),
        };

        public List<Podcast> Fetch()
        {
            return listaPodcast;
        }
    }
}
