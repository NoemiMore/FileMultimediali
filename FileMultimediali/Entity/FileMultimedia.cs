using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
     class FileMultimedia: Autore
    { 
        public string Titolo { get; set; }
        

        public FileMultimedia (string nome, string cognome , int età , string titolo ) : base(nome, cognome, età)
        { Titolo = titolo; }


        public virtual string Print() => $"{Titolo} ";

    }
}
