using ShopApi.Models;

namespace ShopApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
