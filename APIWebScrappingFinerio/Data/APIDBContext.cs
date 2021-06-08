using System;
using APIWebScrappingFinerio.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWebScrappingFinerio.Data
{
    public class APIDBContext: DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options): base (options)
        {
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<SubGenre> SubGenres { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Song> Songs { get; set; }
    }
}
