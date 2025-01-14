using Microsoft.Extensions.Logging;
using RecordShop.Model;

namespace RecordShop.Service
{
    public class AlbumService
    {
        private readonly AlbumModel _albumModel;

        public AlbumService(AlbumModel albumModel)
        {
            _albumModel = albumModel;
        }

        public List<Album> FindAlbums()
        {
            return _albumModel.FindAlbums().ToList();
        }

    }
}
