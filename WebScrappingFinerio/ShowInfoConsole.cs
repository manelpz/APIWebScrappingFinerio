using System;
using System.Collections.Generic;
using WebScrappingFinerio;

namespace WebScrapingFinerio
{
    public class ShowInfoConsole
    {

        string filterValue = "";

        GetInfoWeb GetInfoWeb = new GetInfoWeb();
        //DataBaseConnection DataBaseConnection = new DataBaseConnection();


        public void ShowMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Find artist and insert on DB");
            Console.WriteLine("2) ");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("3) Exit");
                    break;
                case "2":
                    Console.WriteLine("3) Exit");
                    break;
                default:
                    Console.WriteLine("3) Exit");
                    break;
            }
        }
        /*

            switch (Console.ReadLine())
            {
                case "1":
                    //ReverseString();
                    filterValue = "rock";
                    GetInfoWeb.NameClass = ".artist_name";
                    GetInfoWeb.NameURI = $"https://us.napster.com/genre/{filterValue}";

                    var ListInfo = GetInfoWeb.GetInfoFilter();
                    DataBaseConnection.DataBaseConnectionList(ListInfo);
                    showInfoFunc(ListInfo);

                    return true;
                case "2":
                    // RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }*/



        public void showInfoFunc(List<string> dataList)
        {
            foreach (var data in dataList)
            {
                Console.WriteLine(data);
            }
        }

        public void Message(string messageString)
        {
            Console.WriteLine(messageString);
        }

       

    }
}
