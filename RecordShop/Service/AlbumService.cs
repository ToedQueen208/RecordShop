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
            return _albumModel.GetAlbumList();
        }

        public Album FindAlbumById(int id) 
        { 
           return _albumModel.GetAlbum(id);
        }

        public bool AddAlbum(Album album, out Album result) {
            //Check the Albums already in stock
            //Add to list of album
            List<Album> albums = _albumModel.GetAlbumList();

            if (albums.Find(x=>x.albumName == album.albumName) == null) {
                Console.Write("Creating album");
                _albumModel.AddAlbum(album);
                 result = album;
                return true;
              
            }
            else
            {
                result = null;
                return false;
            }

        
        
        }
    }
}
