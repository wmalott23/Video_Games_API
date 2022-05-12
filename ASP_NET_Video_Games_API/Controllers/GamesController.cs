using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    // /api/games
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllVideoGames()
        {
            var allVideoGames = _context.VideoGames.ToList();
            return Ok(allVideoGames);
        }

        [HttpGet("{id}")]
        public IActionResult GetVideoGameById(int id)
        {
            var videoGames = _context.VideoGames.Where(vg => vg.Id == id).SingleOrDefault();
            return Ok(videoGames);
        }

    }
}
