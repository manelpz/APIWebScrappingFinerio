using System;
using System.Collections.Generic;

#nullable disable

namespace WebScrappingFinerio.Model
{
    public partial class Artist
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int? SubGenreId { get; set; }

        public virtual SubGenre SubGenre { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
