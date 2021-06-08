﻿using System;
using System.Collections.Generic;

namespace APIWebScrappingFinerio.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubGenre { get; set; }
        public List<Album> Albums { get; set; }
    }
}
