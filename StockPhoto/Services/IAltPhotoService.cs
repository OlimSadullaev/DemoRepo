using StockPhoto.Entities;

namespace StockPhoto.Services
{
    public interface IAltPhotoService
    {
        public Task<AltPhoto> GetPhotoById(Guid id);
        public Task<List<AltPhoto>> GetPhotosAsync(int take, int skip);
        public Task<(bool IsSuccess, Exception Exception)> UpdatePhotoAsync(AltPhoto altPhoto);
    }
}
