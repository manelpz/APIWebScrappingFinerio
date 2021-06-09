using System;
using System.Collections.Generic;

namespace WebScrapingFinerio
{
    public class ShowInfoConsole
    {
        
        public void showInfoFunc(List<string> dataList)
        {

            foreach (var data in dataList)
            {
                Console.WriteLine(data);
            }
        }

        
    }
}
