using Microsoft.AspNetCore.Mvc;
using ZDatabaseContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YCBackendHomePractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private MyContext _mdc;

        public FilmController(MyContext mdc)
        {
            _mdc = mdc;
        }
        // GET: api/<ValuesController>
        [HttpGet("showMovies")]
        public Film GetMovies()
        {
           _mdc..

        }

        // GET: api/<addnewfilm>
        [HttpGet("newMovie/{Title}/{Rating}/{Price}/{EighteenPlus} ")]
        public Film AddNewMovie(string Title, int Rating, int Price, bool EighteenPlus )
        {
            Film F = new Film();
            F.Title = Title;
            F.Rating = Rating;
            F.Price = Price;
            F.EighteenPlus = EighteenPlus;
            _mdc.Add(F);
            _mdc.SaveChanges();
            return F;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
