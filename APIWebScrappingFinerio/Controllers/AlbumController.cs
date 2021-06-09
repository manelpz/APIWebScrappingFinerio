using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APIWebScrappingFinerio.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWebScrappingFinerio.Controllers
{
    [Route("api/[controller]")]
    public class AlbumController : Controller
    {

        private APIDBContext _dbContext;

        public AlbumController(APIDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        //GET ALBUMS
        [HttpGet("[Action]")]
        public IActionResult AllAlbums(string artistName)
        {
            var albums = from album in _dbContext.Albums
                         join artist in _dbContext.Artists on album.ArtistId equals artist.Id
                         where artist.Name.StartsWith(artistName)
                         select new
                          {
                              Id = album.Id,
                              Name = album.Name,
                              Genre = artist.Name

                          };
            return Ok(albums);
        }

    }
}
