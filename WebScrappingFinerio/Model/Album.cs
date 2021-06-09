using System;
using System.Collections.Generic;

#nullable disable

namespace WebScrappingFinerio.Model
{
    public partial class Album
    {
        public Album()
        {
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
