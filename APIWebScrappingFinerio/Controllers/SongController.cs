using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using APIWebScrappingFinerio.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWebScrappingFinerio.Controllers
{
    [Route("api/[controller]")]
    public class SongController : Controller
    {
        private APIDBContext _dbContext;

        public SongController(APIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET SONGS
        [HttpGet("[Action]")]
        public IActionResult AllSongs(string albumName)
        {
            var songs = from song in _dbContext.Songs
                         join album in _dbContext.Albums on song.AlbumId equals album.Id
                         where album.Name.StartsWith(albumName)
                        select new
                         {
                             Id = song.Id,
                             Name = song.Name,
                             Genre = album.Name

                         };
            return Ok(songs);
        }


    }
}
