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

        //********************************************
        //*******************************************
        /*[HttpGet]
        public IEnumerable<Genre> GenresSubGenres()
        {
            var sub = _dbContext.Genres.Include(x => x.SubGenre).ToList();
            return sub;
        }*/


        //subgenge
        /*var subgenres = from subgenre in _dbContext.SubGenres
                        join genre in _dbContext.Genres on subgenre.GenreId equals genre.Id
                        select new
                        {
                            Id = subgenre.Id,
                            Genre = genre.Name,
                            SubGenreName = subgenre.Name

                        };*/

        //genres
        /*var subgenres = from genre in _dbContext.Genres
                        join subgenre in _dbContext.SubGenres on  genre.Id equals subgenre.Id 
                     select new
                     {
                         Id = subgenre.Id,
                         Genre = genre.Name,
                         SubGenreName = subgenre.Name

                     };*/



        //return Ok(subgenres);




        // GET: api/values
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
