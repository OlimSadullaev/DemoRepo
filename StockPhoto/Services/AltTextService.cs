using StockPhoto.Data;
using StockPhoto.Entities;

namespace StockPhoto.Services
{
    public class AltTextService : IAltTextService
    {
        private readonly StockPhotoDbContext? _ctx;

        public AltTextService(StockPhotoDbContext altText)
        {
            _ctx = altText;
        }

        public async Task<(bool IsSuccess, Exception Exception)> InsetAltTextAsync(AltText altText)
        {
            try
            {
                await _ctx.Texts.AddAsync(altText);
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
