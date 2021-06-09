using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;


namespace WebScrapingFinerio
{
    public class GetInfoWeb
    {
        public string NameURI { get; set; }
        public string NameClass { get; set; }

        public List<string> GetInfoFilter()
        {

            List<string> FilteredList = new List<string>();

            try
            {
                HtmlWeb oWeb = new HtmlWeb();
                HtmlDocument doc = oWeb.Load(NameURI);
                foreach (var Node in doc.DocumentNode.CssSelect(NameClass))
                {
                    var nodeAnchor = Node.CssSelect("a").First();
                    FilteredList.Add(nodeAnchor.InnerHtml);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting data " + ex);
            }

            return FilteredList;
        }

    }
}
