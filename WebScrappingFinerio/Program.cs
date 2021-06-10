using System;
using System.Collections.Generic;
using System.Linq;
using WebScrapingFinerio;

namespace WebScrappingFinerio
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            string filterValue = "";
            List<string> ListInfo = new List<string>();

            GetInfoWeb GetInfoWeb = new GetInfoWeb();
            ShowInfoConsole ShowInfoConsole = new ShowInfoConsole();
            DataBaseConnection DataBaseConnection = new DataBaseConnection();


            ShowInfoConsole.ShowMenu();

            switch (Console.ReadLine())
            {

                case "1":
                    //GenreAndSubGenre
                    Console.WriteLine("GenreAndSubGenre, type Genre:");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".genre-item";
                    GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";

                    ListInfo = GetInfoWeb.GetInfoFilter();
                    DataBaseConnection.GenreAndSubGenre(filterValue, ListInfo);
                    //ShowInfoConsole.showInfoFunc(ListInfo);

                    break;
                case "2":
                    //ArtistByGenre
                    Console.WriteLine("ArtistByGenre, type Genre:");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".artist_name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";

                    ListInfo = GetInfoWeb.GetInfoFilter();
                    DataBaseConnection.ArtistByGenre(filterValue, ListInfo);
                    //ShowInfoConsole.showInfoFunc(ListInfo);

                    break;
                case "3":
                    //AlbumByArtist
                    Console.WriteLine("AlbumByArtist, type Artist:");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".album_name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/artist/{filterValue}";

                    ListInfo = GetInfoWeb.GetInfoFilter();
                    DataBaseConnection.AlbumByArtist(filterValue, ListInfo);
                    //ShowInfoConsole.showInfoFunc(ListInfo);

                    break;
                case "4":
                   
                    Console.WriteLine("SongsByAlbum: type artist");
                    filterValue = Console.ReadLine();
                    Console.WriteLine("SongsByAlbum: type album");
                    string filterValue2 = Console.ReadLine();
                    GetInfoWeb.NameClass = ".no-artist";
                    GetInfoWeb.NameURI = $"https://us.napster.com/artist/{filterValue}/album/{filterValue2}";

                    ListInfo = GetInfoWeb.GetInfoFilter();
                    DataBaseConnection.SongsByAlbum(filterValue, filterValue2, ListInfo);

                    break;
                case "5":
                    
                    //ArtistBySong
                    Console.WriteLine("ArtistBySong: type song");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".artist-name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/search/track?query={filterValue}";

                    ListInfo = GetInfoWeb.GetInfoFilter();
                    ShowInfoConsole.showInfoFunc(ListInfo);

                    break;
                default:
                    break;

            }

            


        }


    }


}




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




