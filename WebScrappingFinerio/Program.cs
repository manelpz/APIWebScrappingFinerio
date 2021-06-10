using System;
using System.Collections.Generic;
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
                    //ShowInfoConsole.showInfoFunc(ListInfo);
                    DataBaseConnection.GenreAndSubGenre(filterValue, ListInfo);
                   

                    break;
                case "2":
                    //ArtistByGenre
                    Console.WriteLine("ArtistByGenre, type Genre:");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".artist_name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";

                    ListInfo = GetInfoWeb.GetInfoFilter();
                    //ShowInfoConsole.showInfoFunc(ListInfo);
                    DataBaseConnection.ArtistByGenre(filterValue, ListInfo);

                    break;
                case "3":
                    //AlbumByArtist
                    Console.WriteLine("AlbumByArtist, type Artist:");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".album_name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/artist/{filterValue}";

                    break;
                case "4":
                    //SongsByAlbum
                    Console.WriteLine("SongsByAlbum, type song:");
                    filterValue = Console.ReadLine();
                    GetInfoWeb.NameClass = ".artist-name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/search/track?query={filterValue}";

                    break;
                case "5":
                    
                    //ArtistBySong
                    Console.WriteLine("ArtistBySong: type artist");
                    filterValue = Console.ReadLine();
                    Console.WriteLine("SongsByAlbum: type song");
                    string filterValue2 = Console.ReadLine();
                    GetInfoWeb.NameClass = ".no-artist";
                    GetInfoWeb.NameURI = $"https://us.napster.com/artist/{filterValue}/album/{filterValue2}";


                    break;

                default:
                    break;

            }

            Console.WriteLine("*********Info Added on DataBase*********");



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




