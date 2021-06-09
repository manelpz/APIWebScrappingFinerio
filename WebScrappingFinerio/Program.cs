using System;
using WebScrapingFinerio;

namespace WebScrappingFinerio
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            GetInfoWeb GetInfoWeb = new GetInfoWeb();
            ShowInfoConsole ShowInfoConsole = new ShowInfoConsole();

            string filterValue = "";

            //GenreAndSubGenre
            filterValue = "rock";
            GetInfoWeb.NameClass = ".genre-item";
            GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";


            //ArtistByGenre
            /*filterValue = "pop";
            GetInfoWeb.NameClass = ".artist_name";
            GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";
            //List<string> filteredList = GetInfoWeb.GetInfoFilter();*/


            //AlbumByArtist
            /*filterValue = "60-tigres";
            GetInfoWeb.NameClass = ".album_name";
            GetInfoWeb.NameURI = $"https://us.napster.com/artist/{filterValue}";
            //List<string> filteredList = GetInfoWeb.GetInfoFilter();*/


            //SongsByAlbum
            /*filterValue = "60-tigres";
            string filterValue2 = "frenesi";
            GetInfoWeb.NameClass = ".no-artist";
            GetInfoWeb.NameURI = $"https://us.napster.com/artist/{filterValue}/album/{filterValue2}";
            //List<string> filteredList = GetInfoWeb.GetInfoFilter();*/

            //ArtistBySong
            /*filterValue = "viento";
            GetInfoWeb.NameClass = ".artist-name";
            GetInfoWeb.NameURI = $"https://us.napster.com/search/track?query={filterValue}";
            //List<string> filteredList = GetInfoWeb.GetInfoFilter();*/


            ShowInfoConsole.showInfoFunc(GetInfoWeb.GetInfoFilter());


        }


    }
}
