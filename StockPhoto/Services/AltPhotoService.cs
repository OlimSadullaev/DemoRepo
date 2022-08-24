using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using StockPhoto.Data;
using StockPhoto.Entities;

namespace StockPhoto.Services
{
    public class AltPhotoService : IAltPhotoService
    {

        private readonly StockPhotoDbContext _ctx;

        public AltPhotoService(StockPhotoDbContext context) => _ctx = context;

        public Task<AltPhoto?> GetPhotoById(Guid id)
        => _ctx.Photos.FirstOrDefaultAsync(c => c.Id == id);

        public Task<List<AltPhoto>> GetPhotosAsync(int take = 10, int skip = 0)
            => _ctx.Photos
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .Include(p => p.Author)
            .ToListAsync();


        /*public Task<List<AltPhoto>> GetPhotosById(Guid id)
        => _ctx.Photos
            .AsNoTracking()
            .Where(c => c.Id == id)
            .ToListAsync();*/
        public async Task<(bool IsSuccess, Exception Exception)> UpdatePhotoAsync(AltPhoto? altPhoto)
        {
            try
            {
                _ctx.Photos.Update(altPhoto);
                await _ctx.SaveChangesAsync();
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }



    }
}
