using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class RepositeryCanzoni: IDbRepositery <Canzone>
    {

        static List<Canzone> listaCanzoni = new List<Canzone>
        {
            new Canzone ("Marco","Gionni", 32, "jfmsnjnfj", GenreEnum.Classica),
            new Canzone ("Edo","Ginni", 42, "jfmsnjnfj", GenreEnum.Rock),
            new Canzone ("Gypsy","Gii", 31, "jfmsnjnfj", GenreEnum.Pop),
            new Canzone ("Barcelona","bgko", 22, "ngndj fjf", GenreEnum.Classica)
        };

        public List<Canzone> Fetch()
        {
            return listaCanzoni;
        }
    }
}
