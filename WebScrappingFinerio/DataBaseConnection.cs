using WebScrappingFinerio.Model;
using WebScrappingFinerio.Data;
using System.Collections.Generic;
using System;

namespace WebScrappingFinerio
{
    public class DataBaseConnection
    {

        public void DataBaseConnectionList(List<string> DataList)
        {

            try
            {
                using (var context = new WebSBDContext())
                {
                    var std = new Artist()
                    {
                        Name = "linkin park",
                        GenreId = 1,
                        SubGenreId = 1
                    };

                    context.Artists.Add(std);
                    context.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error in database: " + ex);
            }
            
        }
    }
}
