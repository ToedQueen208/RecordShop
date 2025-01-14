using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordShop.Service;

namespace RecordShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly AlbumService _albumService;

        public AlbumController(AlbumService albumservice)
        {
            _albumService = albumservice;
        }

        [HttpGet]
        public IActionResult GetAlbums()
        {
            List<Album> albums = _albumService.FindAlbums();
            return Ok(albums);
        }
    }
}
