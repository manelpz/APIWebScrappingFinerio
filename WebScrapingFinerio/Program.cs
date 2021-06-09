using System;
using System.Collections.Generic;


namespace WebScrapingFinerio
{
    class MainClass
    {

        public static void Main(string[] args)
        {


            GetInfoWeb GetInfoWeb = new GetInfoWeb();
            ShowInfoConsole ShowInfoConsole = new ShowInfoConsole();
            
            //List<string> artists = GetInfoWeb.GetAlbumByArtist("60-tigres");

            //ArtistByGenre
            /*GetInfoWeb.NameClass = ".album_name";
            GetInfoWeb.NameURI = "https://us.napster.com/genre/";
            List<string> filteredList = GetInfoWeb.GetInfoFilter("pop");*/
            
            //ArtistBySong
            GetInfoWeb.NameClass = ".album_name";
            GetInfoWeb.NameURI = "https://us.napster.com/search/track?query=";
            List<string> filteredList = GetInfoWeb.GetInfoFilter("viento");

            /*
            //AlbumByArtist
            GetInfoWeb.NameClass = ".album_name";
            GetInfoWeb.NameURI = "https://us.napster.com/artist/{artist}";
            */

            ShowInfoConsole.showInfoFunc(filteredList);


        }

        
    }




}
