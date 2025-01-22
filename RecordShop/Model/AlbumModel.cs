using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Text.Json;

namespace RecordShop.Model
{
    public class AlbumModel
    {
        private static List<Album> albumList = new List<Album>();

        private RecordShopDbContext db;
        public  AlbumModel(RecordShopDbContext dbContext)
        {

            db = dbContext; 
        }


        public List<Album> GetAlbumList()
        {
            return db.Albums.ToList();
        }
        //public IEnumerable<Album> FindAlbums()
        //{
        //    if (albumList.IsNullOrEmpty())
        //    {
        //        albumList = GetAlbumList();
              
               
        //    }
        //    return albumList;
        //}

        public Album GetAlbum(int id) 
        {


            albumList = GetAlbumList();
            var album = albumList.Find(x => x.id == id);
            if (album != null)
            {
                return album;
            }
            {
                return null;
            }
        }


        public Album AddAlbum(Album album)
        {
                       db.Albums.Add(album);
            db.SaveChanges();
            Console.WriteLine("Created album");
            return album;
            /*
            album.id = FindAlbums().Last().id + 1;

            albumList.Add(album);

            return albumList.Find(x=>x.id == album.id);
            */
        }

        public void RemoveAlbum(Album album)
        {
            var albumToDelete = db.Albums.SingleOrDefault(a => a.id == album.id);
            db.Albums.Remove(albumToDelete);
            db.SaveChanges() ;
            
        }
        public Album UpdateAlbum(Album album) 
        {
                var albumToUpdate = db.Albums.SingleOrDefault(a => a.id == album.id);
                     //albumToUpdate.id = album.id;
            albumToUpdate.albumName = album.albumName;
            albumToUpdate.artistName = album.artistName;
            albumToUpdate.Songs = album.Songs;
            db.SaveChanges();
            return albumToUpdate;
           
        }
    }
}
