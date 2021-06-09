using System;
using WebScrapingFinerio;

namespace WebScrappingFinerio
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string filterValue = "";

            GetInfoWeb GetInfoWeb = new GetInfoWeb();
            ShowInfoConsole ShowInfoConsole = new ShowInfoConsole();
            DataBaseConnection DataBaseConnection = new DataBaseConnection();

            ShowInfoConsole.ShowMenu();

            //GenreAndSubGenre
            /*filterValue = "rock";
            GetInfoWeb.NameClass = ".genre-item";
            GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";
            */


            //ArtistByGenre
            /*
             * filterValue = "rock";

            GetInfoWeb.NameClass = ".artist_name";
            GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";

            var ListInfo= GetInfoWeb.GetInfoFilter();
            DataBaseConnection.DataBaseConnectionList(ListInfo);
            */

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





        }


    }




}
