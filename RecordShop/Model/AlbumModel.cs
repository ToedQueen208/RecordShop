using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json;

namespace RecordShop.Model
{
    public class AlbumModel
    {
        public List<Album> albumList = new List<Album>();


        public static List<Album> GetAlbumList()
        {
          return JsonSerializer.Deserialize<List<Album>>(File.ReadAllText("Albums.json"));
        }
        public IEnumerable<Album> FindAlbums()
        {
            if (albumList.IsNullOrEmpty())
            {
                albumList = GetAlbumList();
                Console.WriteLine("Creating new list");
            }
            return albumList;
        }
    }
}
