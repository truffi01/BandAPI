using BandAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Services
{
    public interface IBandAlbumRepository
    {
        //Method that allows the API to get the albums for each of the bands. ALbums for individual bands so pass in Guid 
        IEnumerable<Album> GetAlbums(Guid bandId);
        
        //want ot get a single item of a band. Need to know id of band and the album id
        Album GetAlbum(Guid bandId, Guid albumId);

        //perform crud operatoions. 
        void AddAlbum(Guid bandId, Album album);
        void UpdateAlbum(Album album);
        void DeleteAlbum(Album album);

        //Get all bands in database. Grt list of all bands avaible in database.
        IEnumerable<Band> GetBands();

        //get a single band
        Band GetBand(Guid bandId);

        //get specific bands. Want a specific so we pass in guids of the bands we are looking for 
        IEnumerable<Band> GetBands(IEnumerable<Guid> bandIds);
        void AddBand(Band band);
        void UpdateBand(Band band);
        void DeleteBand(Band band);

        //check if band exists
        bool BandExists(Guid bandId);
        //method to save information in database. Boolean that return success or not of saving
        bool AlbumExists(Guid albumId);
        bool Save(); 
    }
}
