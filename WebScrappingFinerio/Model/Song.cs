using System;
using System.Collections.Generic;

#nullable disable

namespace WebScrappingFinerio.Model
{
    public partial class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
