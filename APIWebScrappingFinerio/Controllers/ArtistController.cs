using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APIWebScrappingFinerio.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWebScrappingFinerio.Controllers
{

    [Route("api/[controller]")]
    public class ArtistController : Controller
    {

        private APIDBContext _dbContext;

        public ArtistController(APIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET ARTIST
        [HttpGet("[Action]")]
        public IActionResult AllArtists(string genreName)
        {
            var artists = from artist in _dbContext.Artists
                          join genre in _dbContext.Genres on artist.GenreId equals genre.Id
                          where genre.Name.StartsWith(genreName)
                          select new
                            {
                                Id = artist.Id,
                                Name = artist.Name,
                                Genre = genre.Name

                            };
            return Ok(artists);
        }


        //GET ARTIST X SONG
        [HttpGet("[Action]")]
        public IActionResult FindArtist(string songName)
        {
            var findArtist = from artist in _dbContext.Artists
                             join album in _dbContext.Albums on artist.Id equals album.ArtistId
                             join song in _dbContext.Songs on album.Id equals song.AlbumId
                          where song.Name.StartsWith(songName)
                          select new
                          {
                              Id = artist.Id,
                              Name = artist.Name,
                              Song = song.Name

                          };
            return Ok(findArtist);
        }

    }
}
