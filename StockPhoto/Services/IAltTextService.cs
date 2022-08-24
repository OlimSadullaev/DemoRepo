using StockPhoto.Entities;

namespace StockPhoto.Services
{
    public interface IAltTextService
    {
        public Task<(bool IsSuccess, Exception Exception)> InsetAltTextAsync(AltText altText);

    }
}