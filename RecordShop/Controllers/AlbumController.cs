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

        //    GetByID
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAlbumByID(string id)
        {
            int.TryParse(id, out int albumID);
            Album album = _albumService.FindAlbumById(albumID);
          
            if (album != null) {
                return Ok($"We have found Album with name {album.albumName} and ID {album.id}" );
            }
            else
            {
                return BadRequest("You entered an inccorect ID number");
            }

        }

        // Add an album
        [HttpPost]
        [Route("AddAlbum")]
        public IActionResult AddAlbum(Album album) {
            if (_albumService.AddAlbum(album, out Album result)) {

                return Created($"The Album has been added to the Shop with the ID of " + result.id.ToString(), result);
            }

            return BadRequest("The data you entered was incorrect");
        }
        /*
        ENDPOINTS

    


        GetByArtist?

        Add an album

        Change an album

        Remove an Album

        HealthChecks

       */
    }
}
