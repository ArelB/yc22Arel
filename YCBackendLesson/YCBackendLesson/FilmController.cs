using DatabaseContextYC;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YCBackendLesson
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {

        private MyContext mc;
        
        public FilmController(MyContext MC)
        {
            mc = MC;
        }


        // GET: api/<FilmController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
           /* Film f = new Film();
            f.Titel = "Matrix";
            f.Rating = 5;
            f.Prijs = 1800;
            f.achtienPlus = true;
            mc.Add(f);
            mc.SaveChanges();*/
            return new string[] { "Titel", "Mr Bean" };
        }

        // GET: api/<FilmController>
        [HttpGet("showfilm")]
        public IEnumerable<string> GetFilm()
        {
             Film f = new Film();
             f.Titel = "Matrix";
             f.Rating = 5;
             f.Prijs = 1800;
             f.achtienPlus = true;
            return new string[] { "Titel", "Mr Bean", "Prijs","1500", "Rating", "5", "achtienPlus","True" };
        }

        [HttpGet("nwfilm/{detitel}")]
        public Film GetMovie(string detitel)
        {
            Film f = new Film();
            f.Titel = detitel;
            f.Rating = 5;
            f.Prijs = 1500;
            f.achtienPlus = true;
            mc.Add(f);
            mc.SaveChanges();
            return f;
        }

        // GET: api/<FilmController>
        [HttpGet("/nwfilm/all")]
        public IEnumerable<Film> GetMovies()
        {
            return mc.films;
        }


        // GET: api/<FilmController>
        [HttpGet("/nwfilm/{detitel}")]
        public IEnumerable<string> GetFred(string titel)
        {
            return new string[] { "Titel", titel };
        }

        // GET api/<FilmController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FilmController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilmController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
