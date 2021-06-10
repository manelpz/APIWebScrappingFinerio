using System;
using System.Collections.Generic;
using WebScrappingFinerio;

namespace WebScrapingFinerio
{
    public class ShowInfoConsole
    {

        string filterValue = "";


        public void ShowMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Genre and SubGenre");
            Console.WriteLine("2) Artist  by Genre");
            Console.WriteLine("3) Album by Artist");
            Console.WriteLine("4) Songs by Album");
            Console.WriteLine("5) Artist by Song");
            Console.Write("\r\nSelect an option: "); 
        }
        
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
