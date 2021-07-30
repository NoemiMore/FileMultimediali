using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    class Podcast : FileMultimedia, IRepositeryEpisodi
    { string Descrizione { get; set;}

        public Podcast(string nome, string cognome, int età, string titolo, string descrizione) : base(nome, cognome, età, titolo)
        { Descrizione = descrizione; }



        public override string Print()
        {
            return $"{base.Print()} - {Descrizione}";
        }


    }
}
