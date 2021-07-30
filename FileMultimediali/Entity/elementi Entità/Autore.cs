using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
     abstract class Autore 

    { public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }

        public Autore(string nome, string cognome, int età) 
        { Nome = nome;
            Cognome = cognome;
            Età = età;
        }
    }
    
}
