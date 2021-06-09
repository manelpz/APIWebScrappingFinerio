using System;
using Microsoft.EntityFrameworkCore;
using WebScrappingFinerio.Model;

namespace WebScrappingFinerio.Data
{
    public class WebSBDContext : DbContext
    {
        
        public DbSet<Genre> Genres { get; set; }

        public DbSet<SubGenre> SubGenres { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Song> Songs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:cinemadb1.database.windows.net,1433;Initial Catalog=fineriodb1;Persist Security Info=False;User ID=manelpz;Password=Mexico.2012df45;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
