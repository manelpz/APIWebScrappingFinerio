using WebScrappingFinerio.Model;
using WebScrappingFinerio.Data;
using System.Collections.Generic;
using System;
using System.Linq;
using WebScrapingFinerio;

namespace WebScrappingFinerio
{
    public class DataBaseConnection
    {
        ShowInfoConsole ShowInfoConsole = new ShowInfoConsole();

        public void DataBaseConnectionList(List<string> DataList)
        {
            if (DataList != null && (DataList.Any()))
            {
                foreach (var data in DataList)
                {
                    try
                    {
                        using (var context = new WebSBDContext())
                        {
                            var std = new Artist()
                            {
                                Name = data,
                                GenreId = 1,
                                SubGenreId = 1
                            };

                            context.Artists.Add(std);
                            context.SaveChanges();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        ShowInfoConsole.Message("Error in database: " + ex);
                    }
                }

            }
            else
            {
                ShowInfoConsole.Message("No results found ");
            }


        }
    }
}
