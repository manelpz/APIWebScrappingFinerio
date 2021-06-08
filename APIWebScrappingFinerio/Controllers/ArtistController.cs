using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using APIWebScrappingFinerio.Data;
using APIWebScrappingFinerio.Models;
using Microsoft.EntityFrameworkCore;

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
                          where genre.Name == genreName
                          select new
                            {
                                Id = artist.Id,
                                Name = artist.Name,
                                Genre = genre.Name

                            };
            return Ok(artists);
        }


    }
}
