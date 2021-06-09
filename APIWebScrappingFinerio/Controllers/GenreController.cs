using System.Linq;
using Microsoft.AspNetCore.Mvc;
using APIWebScrappingFinerio.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWebScrappingFinerio.Controllers
{
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        private APIDBContext _dbContext;

        public GenreController(APIDBContext dbContext)
        {
            _dbContext = dbContext;
        }
               
        //GET ALLGENRES
        [HttpGet("[Action]")]
        public IActionResult AllGenres()
        {
            var genres = _dbContext.Genres.Include(x => x.SubGenre).ToList();
            return Ok(genres);
        }

       

    }
}
