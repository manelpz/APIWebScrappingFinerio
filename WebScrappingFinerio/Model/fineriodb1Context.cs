using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebScrappingFinerio.Model
{
    public partial class fineriodb1Context : DbContext
    {
        public fineriodb1Context()
        {
        }

        public fineriodb1Context(DbContextOptions<fineriodb1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SubGenre> SubGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:cinemadb1.database.windows.net,1433;Initial Catalog=fineriodb1;Persist Security Info=False;User ID=manelpz;Password=Mexico.2012df45;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasIndex(e => e.ArtistId, "IX_Albums_ArtistId");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.ArtistId);
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasIndex(e => e.SubGenreId, "IX_Artists_SubGenreId");

                entity.HasOne(d => d.SubGenre)
                    .WithMany(p => p.Artists)
                    .HasForeignKey(d => d.SubGenreId);
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasIndex(e => e.AlbumId, "IX_Songs_AlbumId");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId);
            });

            modelBuilder.Entity<SubGenre>(entity =>
            {
                entity.HasIndex(e => e.GenreId, "IX_SubGenres_GenreId");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.SubGenres)
                    .HasForeignKey(d => d.GenreId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
