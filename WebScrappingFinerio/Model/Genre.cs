using System;
using System.Collections.Generic;

#nullable disable

namespace WebScrappingFinerio.Model
{
    public partial class Genre
    {
        public Genre()
        {
            SubGenres = new HashSet<SubGenre>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SubGenre> SubGenres { get; set; }
    }
}
