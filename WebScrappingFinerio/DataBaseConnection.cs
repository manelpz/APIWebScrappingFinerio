﻿using WebScrappingFinerio.Model;
using WebScrappingFinerio.Data;
using System.Collections.Generic;
using System;
using System.Linq;
using WebScrapingFinerio;

namespace WebScrappingFinerio
{
    public class DataBaseConnection
    {
        ShowInfoConsole ShowInfoConsole = new ShowInfoConsole();

        public void GenreAndSubGenre(string genre, List<string> DataList)
        {

            List<SubGenre> SubGenreList = new List<SubGenre>();

            if (DataList != null && (DataList.Any()))
            {
                var context = new WebSBDContext();

                var IdGenre = context.Genres
                                    .Where(s => s.Name == genre)
                                    .Select(s => s.Id)
                                    .FirstOrDefault();

                if (IdGenre.Equals(0)) {
                    //insert gerne
                    using (context)
                    {
                        var genreList = new Genre()
                        {
                            Name = genre
                        };
                        context.Genres.Add(genreList);
                        context.SaveChanges();
                        IdGenre = genreList.Id;
                    }
                }

                try
                {
                    foreach (var data in DataList)
                    {
                        SubGenreList.Add(new SubGenre { Name = data, GenreId = IdGenre });
                        context.SubGenres.AddRange(SubGenreList);
                    }
                    context.SaveChanges();
                    Console.WriteLine($"{ DataList.Count} rows inserted in DB");
                }
                catch (System.Exception ex)
                {
                    ShowInfoConsole.Message("Error in database: " + ex);
                }  
            }
            else
            {
                ShowInfoConsole.Message("No results found ");
            }


        }


        public void ArtistByGenre(string genre, List<string> DataList)
        {

            List<Artist> ArtistList = new List<Artist>();

            if (DataList != null && (DataList.Any()))
            {
                var context = new WebSBDContext();

                var IdGenre = context.Genres
                                    .Where(s => s.Name == genre)
                                    .Select(s => s.Id)
                                    .FirstOrDefault();

                if (IdGenre.Equals(0))
                {
                    //insert gerne
                    using (context)
                    {
                        var genreList = new Genre()
                        {
                            Name = genre
                        };
                        context.Genres.Add(genreList);
                        context.SaveChanges();
                        IdGenre = genreList.Id;
                    }
                }

                try
                {
                    foreach (var data in DataList)
                    {
                        ArtistList.Add(new Artist { Name = data, GenreId = IdGenre, SubGenreId = null });
                        context.Artists.AddRange(ArtistList);
                    }
                    context.SaveChanges();
                    Console.WriteLine($"{ DataList.Count} rows inserted in DB");
                }
                catch (System.Exception ex)
                {
                    ShowInfoConsole.Message("Error in database: " + ex);
                }
            }
            else
            {
                ShowInfoConsole.Message("No results found ");
            }


        }


        public void AlbumByArtist(string artist, List<string> DataList)
        {

            List<Album> AlbumList = new List<Album>();

            if (DataList != null && (DataList.Any()))
            {
                var context = new WebSBDContext();

                var IdArtist = context.Genres
                                    .Where(s => s.Name == artist)
                                    .Select(s => s.Id)
                                    .FirstOrDefault();

                if (IdArtist.Equals(0))
                {
                    //insert artist
                    using (context)
                    {
                        var artistList = new Artist()
                        {
                            Name = artist
                        };
                        context.Artists.Add(artistList);
                        context.SaveChanges();
                        IdArtist = artistList.Id;
                    }
                }

                try
                {
                    foreach (var data in DataList)
                    {
                        AlbumList.Add(new Album { Name = data, ArtistId = IdArtist});
                        context.Albums.AddRange(AlbumList);
                    }
                    context.SaveChanges();
                    Console.WriteLine($"{ DataList.Count} rows inserted in DB");
                }
                catch (System.Exception ex)
                {
                    ShowInfoConsole.Message("Error in database: " + ex);
                }
            }
            else
            {
                ShowInfoConsole.Message("No results found ");
            }


        }


    }
}
