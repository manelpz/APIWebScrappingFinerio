using System;
using System.Collections.Generic;

#nullable disable

namespace WebScrappingFinerio.Model
{
    public partial class SubGenre
    {
        public SubGenre()
        {
            Artists = new HashSet<Artist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
    }
}
