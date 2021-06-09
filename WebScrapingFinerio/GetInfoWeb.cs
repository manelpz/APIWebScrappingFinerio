using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace WebScrapingFinerio
{
    public class GetInfoWeb
    {
        public string NameURI
        { get; set; }

        public string NameClass
        { get; set; }

        public List<string> GetInfoFilter(string FilterValue)
        {

            List<string> FilteredList = new List<string>();

            HtmlWeb oWeb = new HtmlWeb();
            //HtmlDocument doc = oWeb.Load($"{NameURI}{FilterValue}");
            HtmlDocument doc = oWeb.Load($"https://us.napster.com/search/track?query={FilterValue}");


            foreach (var Node in doc.DocumentNode.CssSelect(NameClass))
            {
                var nodeAnchor = Node.CssSelect("a").First();
                FilteredList.Add(nodeAnchor.InnerHtml);

            }
            return FilteredList;
        }

        /*public List<string> GetAlbumByArtist(string artist)
        {

            HtmlWeb oWeb = new HtmlWeb();
            HtmlDocument doc = oWeb.Load($"https://us.napster.com/artist/{artist}");

            List<string> artists = new List<string>();

            foreach (var Node in doc.DocumentNode.CssSelect(".album_name"))
            {
                var nodeAnchor = Node.CssSelect("a").First();
                artists.Add(nodeAnchor.InnerHtml);

            }
            return artists;
        }

        public List<string> GetArtistBySong(string song)
        {

            HtmlWeb oWeb = new HtmlWeb();
            HtmlDocument doc = oWeb.Load($"https://us.napster.com/search/track?query={song}");

            List<string> artists = new List<string>();

            foreach (var Node in doc.DocumentNode.CssSelect(".artist-name"))
            {
                var nodeAnchor = Node.CssSelect("a").First();
                artists.Add(nodeAnchor.InnerHtml);

            }
            return artists;
        }


        public List<string> GetSongsByAlbum(string song)
        {

            HtmlWeb oWeb = new HtmlWeb();
            HtmlDocument doc = oWeb.Load($"https://us.napster.com/search/track?query={song}");

            List<string> artists = new List<string>();

            foreach (var Node in doc.DocumentNode.CssSelect(".artist-name"))
            {
                var nodeAnchor = Node.CssSelect("a").First();
                artists.Add(nodeAnchor.InnerHtml);

            }
            return artists;
        }*/


    }
}
