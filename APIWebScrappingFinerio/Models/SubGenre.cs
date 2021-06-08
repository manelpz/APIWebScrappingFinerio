using System;
using System.Collections.Generic;

namespace APIWebScrappingFinerio.Models
{
    public class SubGenre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
