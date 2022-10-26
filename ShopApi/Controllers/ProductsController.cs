using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApi.Models;
using ShopApi.Services;

namespace ShopApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService ProductService)
        {
            this.productService = ProductService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await productService.GetAllProducts());
        }
    }
}
