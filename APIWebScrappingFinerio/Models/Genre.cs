using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIWebScrappingFinerio.Models
{
    public class Genre
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public List<SubGenre> SubGenre { get; set; }
        
    }
}

