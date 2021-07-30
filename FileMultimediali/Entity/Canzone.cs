using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    internal class Canzone : FileMultimedia
    {
        public GenreEnum GenereMusicale { get; set; }

        public Canzone(string nome, string cognome, int età, string titolo, GenreEnum genereMusicale) : base(nome, cognome, età, titolo)
        { GenereMusicale = genereMusicale; }







        public override string Print()
        {
            return $"{base.Print()} - {GenereMusicale}";
        }

    }
    
    
    
    enum GenreEnum
    {
        Pop, 
       Rock, 
        Classica,
       
    }



}
