using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    static class Utente
    {

        public static RepositeryCanzoni repCanzoni = new RepositeryCanzoni();
        public static RepositeryPodcast repPodcast = new RepositeryPodcast();






        public static void Menu()

        {
            bool procedi = true; ;
            int scelta;

            while (procedi)
            {
                Console.WriteLine("Premi 1 per vedere tutte le canzoni");
                Console.WriteLine("Premi 2 per vedere tutti i podcast");
                Console.WriteLine("Premi 3 per scegliere il genere delle canzoni");
                Console.WriteLine("Premi 4 per scegliere un podcast e visualizzare tutti gli episodi");
                Console.WriteLine("Premi 5 per scegliere la durata massima dell'episodio che vuoi vedere");
                Console.WriteLine("Premi 0 per uscire");

                do
                {
                    Console.WriteLine("Scegli l'opzione che desideri");
                } while (!int.TryParse(Console.ReadLine(), out scelta));


                switch (scelta)
                {
                    case 1:
                        { // far visualizzare tutta la lista delle canzoni

                            List<Canzone> listaCanzoni = repCanzoni.Fetch();
                            StampaLaLista(listaCanzoni);


                            break;
                        }
                    case 2:
                        { // visualizza tutti i podcast
                            List<Podcast> listaPodcast = repPodcast.Fetch();
                            StampaLaLista(listaPodcast);
                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                    case 0:
                        {
                            procedi = false;

                            break;
                        }
                } // chiusura switch

            }
        }

        private static void StampaLaLista(List<Canzone> listaCanzoni)
        {
            foreach (var canzone in listaCanzoni)
            {
                Canzone.Print();
            }
        }


        private static void StampaLaLista(List<Podcast> listaPodcast)
        {
            foreach (var podcast in listaPodcast)
            {
                Podcast.Print();
            }
        }
    }
}


           
     




   
           


        
       
        
        
        
       
             




   


