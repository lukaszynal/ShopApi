using Microsoft.EntityFrameworkCore;
using ShopApi.Models;

namespace ShopApi.Services
{
    public class ProductService : IProductService
    {
        private ShopContext context;

        public ProductService(ShopContext Context)
        {
            this.context = Context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await context.Products.ToListAsync();
        }
    }
}
